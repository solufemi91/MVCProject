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

        public JObject GetPostcodeData(string postcode)
        {
            string extention = $"/postcodes/{postcode}";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            var response = client.GetAsync(extention).Result;
            return JsonConvert.DeserializeObject<JObject>(response.Content.ReadAsStringAsync().Result);
        }

        public string GetParliamentaryConstituency(string postcode)
        {
            return GetPostcodeData(postcode)["result"]["parliamentary_constituency"].ToString();
        }

        public string GetClinicalCommissioningGroup(string postcode)
        {
            return GetPostcodeData(postcode)["result"]["ccg"].ToString();
        }
    }
}