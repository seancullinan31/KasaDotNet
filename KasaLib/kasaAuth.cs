using KasaLib.InputObjects;
using KasaLib.ResponseObjects;
using System.Text;
using System.Text.Json;

namespace KasaLib
{
    public class kasaAuth : kasaBase
    {
        private static kasaAuth _instance;
        public static kasaAuth Instance()
        {
            if (_instance == null)
            {
                _instance = new kasaAuth();
            }
            return _instance;
        }
        public async Task<kasaAuthToken> postAuth(string userName, string password)
        {
            var inputObj = new kasaAuthInput() { method = "login", parameters = new kasaAuthInputParameters() { appType = "Kasa_Android", cloudUserName = userName, cloudPassword = password, terminalUUID = Guid.NewGuid().ToString() } };
            var jsonInput = JsonSerializer.Serialize(inputObj);
            StringContent jsonContent = new(jsonInput, Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var httpResponse = await client.PostAsync(BaseUri, jsonContent);
            var jsonResponse = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<kasaAuthToken>(jsonResponse);
        }
    }
}
