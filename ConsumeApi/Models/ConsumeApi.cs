using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ConsumeApi.Models
{
    public class PostcodesApi
    {
        private string baseUrl = "https://postcodes.io/";
        
        public string GetParliamentaryConstituency(string postcode)
        {
            string extention = $"/postcodes/{postcode}";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            var response = client.GetAsync(extention).Result;
            string result = response.Content.ReadAsStringAsync().Result;
            var jobject = JsonConvert.DeserializeObject<JObject>(result);
            return jobject["result"]["parliamentary_constituency"].ToString();

        }

    }
}