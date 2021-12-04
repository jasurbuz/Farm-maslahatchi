using FarmMaslahatchi.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using FarmMaslahatchi.Data.Model;

namespace Farm_Maslahatchi.Services.Repository
{
    public class GenericRepository<T> where T : class 
    {
        private readonly string ID;
        private readonly string Version;
        private HttpClient Client;
        public GenericRepository(string databaseId, string databaseVersion)
        {
            ID = databaseId;
            Version = databaseVersion;
            Client = new HttpClient();
            Client.BaseAddress = new Uri("http://data.gov.uz/uz/api/v1/json/dataset/");
        }
        public async Task<IList<T>> GetAll()
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, $"{ID}/version/{Version}?access_key={Constants.Key}");
            var response = await Client.SendAsync(message);
            var @string = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<IList<T>>(@string);
            return res;
        }
    }
}
