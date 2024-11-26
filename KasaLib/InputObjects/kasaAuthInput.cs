using System.Text.Json.Serialization;

namespace KasaLib.InputObjects
{
    public class kasaAuthInput : kasaInputBase
    {
        [JsonPropertyName("params")]
        public kasaAuthInputParameters parameters { get; set; }
    }
    public class kasaAuthInputParameters
    {
        public string appType { get; set; }
        public string cloudUserName { get; set; }
        public string cloudPassword { get; set; }
        public string terminalUUID { get; set; }
    }
}
