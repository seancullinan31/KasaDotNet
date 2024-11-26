using KasaLib.InputObjects;
using KasaLib.ResponseObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KasaLib
{
    public class kasaDevices : kasaBase
    {
        private static kasaDevices _instance;
        public static kasaDevices Instance()
        {
            if (_instance == null)
            {
                _instance = new kasaDevices();
            }
            return _instance;
        }
        public async Task<kasaDeviceList> getDeviceList(kasaAuthToken authToken)
        {
            var inputObj = new kasaInputBase() { method = "getDeviceList" };
            var jsonInput = JsonSerializer.Serialize(inputObj);
            StringContent jsonContent = new(jsonInput, Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var httpResponse = await client.PostAsync(TokenizedUri(authToken), jsonContent);
            var jsonResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<kasaDeviceList>(jsonResponse);
        }
    }
}
