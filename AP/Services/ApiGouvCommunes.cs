﻿using AP.dtos;
using AP.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AP.Services
{
    public class ApiGouvCommunes : Bdd
    {
        private HttpClient _http = new HttpClient();
        private List<string> _nosRegionsString = new List<string>();
        public List<ApiRegionDto> ListeNosRegions;
        private List<Region> _listRegions;

        public ApiGouvCommunes()
        {
            _listRegions = new List<Region>();

            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT * FROM regions";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                Region Region = new Region(reader.GetInt32(0), reader.GetString(1), reader.GetFloat(2), reader.GetFloat(3), reader.GetInt32(4), reader.GetString(5));
                _listRegions.Add(Region);
            }
            _bdd.Close();

            foreach (Region region in _listRegions)
            {
                _nosRegionsString.Add(region.Libelle);
            }
        }

        // Permet de récupérer les code régions du gouvernement qui ne sont évidemment pas les mêmes que les id des régions en BDD
        public async Task<List<ApiRegionDto>> GetRegions()
        {
            List<ApiRegionDto> ListeRegion = await _http.GetFromJsonAsync<List<ApiRegionDto>>("https://geo.api.gouv.fr/regions?fields=nom,code");
            return ListeRegion.Where(w => _nosRegionsString.Contains(w.nom)).ToList();
        }

        public async Task<List<ApiCommuneDto>> ListeCommunes(int code_postal)
        {
            return await _http.GetFromJsonAsync<List<ApiCommuneDto>>("https://geo.api.gouv.fr/communes?codePostal=" + code_postal + "&fields=nom,code,codesPostaux,codeDepartement,codeRegion,population&format=json&geometry=centre");
        } 
        
        public async Task<List<ApiCommuneDto>> ListeCommunes(string commune)
        {
            return await _http.GetFromJsonAsync<List<ApiCommuneDto>>("https://geo.api.gouv.fr/communes?nom=" + commune + "&fields=nom,code,codesPostaux,codeDepartement,codeRegion,population&format=json&geometry=centre");
        }

        public async Task<ApiCoordonneesRootDto> GetCoordonnees(string adresse, string citycode)
        {
            return await _http.GetFromJsonAsync<ApiCoordonneesRootDto>("https://api-adresse.data.gouv.fr/search/?q=" + adresse + "&citycode=" + citycode);
        }

        public async Task<ApiCoordonneesRootDto> GetCoordonneesVille(string ville, string lat, string lng)
        {
            return await _http.GetFromJsonAsync<ApiCoordonneesRootDto>("https://api-adresse.data.gouv.fr/search/?q=" + ville + "&type=municipality&lat=" + lat + "&lon=" + lng + "&limit=1");
        }


    }
}
