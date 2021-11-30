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
            GetRegions(); 
        }

        public async void GetRegions()
        {
            List<ApiRegionDto> ListeRegion = await _http.GetFromJsonAsync<List<ApiRegionDto>>("https://geo.api.gouv.fr/regions?fields=nom,code");
            _listeNosRegions = ListeRegion.Where(w => _nosRegionsString.Contains(w.nom)).ToList();
        }

        public async Task<List<ApiCommuneDto>> ListeCommunes(int value)
        {
            return await _http.GetFromJsonAsync<List<ApiCommuneDto>>("https://geo.api.gouv.fr/communes?codePostal=" + value + "&fields=nom,code,codesPostaux,codeDepartement,codeRegion,population&format=json&geometry=centre");
        } 
        
        public async Task<List<ApiCommuneDto>> ListeCommunes(string value)
        {
            return await _http.GetFromJsonAsync<List<ApiCommuneDto>>("https://geo.api.gouv.fr/communes?nom=" + value + "&fields=nom,code,codesPostaux,codeDepartement,codeRegion,population&format=json&geometry=centre");
        }


    }
}
