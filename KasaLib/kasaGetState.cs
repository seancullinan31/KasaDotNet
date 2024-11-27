using System.Text;
using System.Text.Json;
using KasaLib.InputObjects;
using KasaLib.ResponseObjects;

namespace KasaLib
{
    public class kasaGetState : kasaBase {
        private static kasaGetState _instance;
        public static kasaGetState Instance()
        {
            if (_instance == null)
            {
                _instance = new kasaGetState();
            }
            return _instance;
        }
        public async Task<string> getDeviceState(kasaAuthToken authToken, string deviceId)
        {
            var inputObj = new kasaGetStateInput() { method = "passthrough" };
            inputObj.parameters = new  kasaGetStateInputParameters() { deviceId = deviceId };
            inputObj.parameters.requestData = new kasaGetStateInputParametersRequestData();
            var jsonInput = JsonSerializer.Serialize(inputObj);
            StringContent jsonContent = new(jsonInput, Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var httpResponse = await client.PostAsync(TokenizedUri(authToken), jsonContent);
            var jsonResponse = await httpResponse.Content.ReadAsStringAsync();
            return jsonResponse; // JsonSerializer.Deserialize<kasaDeviceList>(jsonResponse);
        }
    }
}