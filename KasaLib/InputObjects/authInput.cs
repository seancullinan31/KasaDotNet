using System.Text.Json.Serialization;

namespace KasaLib.InputObjects
{
    public class authInput
    {
        public string method { get; set; }
        [JsonPropertyName("params")]
        public authInputParameters parameters { get; set; }

    }
    public class authInputParameters
    {
        public string appType { get; set; }
        public string cloudUserName { get; set; }
        public string cloudPassword { get; set; }
        public string terminalUUID { get; set; }
    }
}
