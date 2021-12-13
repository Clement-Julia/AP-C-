using AP.dtos;
using AP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AP.Services
{
    public class ApiGouvCommunes : Bdd
    {
        private HttpClient _http = new HttpClient();
        private List<int> _idRegions = new List<int>();
        private List<string> _nosRegionsString = new List<string>() { "Centre-Val de Loire", "Pays de la Loire", "Bretagne", "Nouvelle-Aquitaine" };
        public List<ApiRegionDto> _listeNosRegions;
        public ApiGouvCommunes()
        {
            // GetRegions(); 
        }

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
        
        public async Task<List<ApiCommuneDto>> ListeCommunes(int code_postal, string commune)
        {
            return await _http.GetFromJsonAsync<List<ApiCommuneDto>>("https://geo.api.gouv.fr/communes?codePostal=" + code_postal + "&nom=" + commune + "&fields=nom,code,codesPostaux,codeDepartement,codeRegion,population&format=json&geometry=centre");
        }



        public async Task<ApiCoordonneesRootDto> GetCoordonnees(string adresse, string citycode)
        {
            return await _http.GetFromJsonAsync<ApiCoordonneesRootDto>("https://api-adresse.data.gouv.fr/search/?q=" + adresse + "&citycode=" + citycode);
        }


    }
}
