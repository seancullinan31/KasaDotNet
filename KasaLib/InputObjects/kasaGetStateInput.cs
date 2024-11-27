using System.Text.Json.Serialization;

namespace KasaLib.InputObjects
{
    public class kasaGetStateInput : kasaInputBase {
        [JsonPropertyName("params")]
        public kasaGetStateInputParameters parameters {get;set;}
    }
    public class kasaGetStateInputParameters {
        public string deviceId {get ;set;}
        public kasaGetStateInputParametersRequestData requestData {get;set;}
    }
    public class kasaGetStateInputParametersRequestData {
        public  kasaGetStateSystemInputParameters system {get;set;} = new kasaGetStateSystemInputParameters();
        public kasaGetStateSystemInputEmeter emeter {get; set;} = new kasaGetStateSystemInputEmeter();
    }
    public class kasaGetStateSystemInputParameters {
        public string get_sysinfo = null;
    }
    public class kasaGetStateSystemInputEmeter {
        public string get_realtime = null;
    }
}