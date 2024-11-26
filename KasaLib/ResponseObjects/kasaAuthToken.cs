using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaLib.ResponseObjects
{


    public class kasaAuthToken
    {
        public int error_code { get; set; }
        public kasaAuthTokenResult result { get; set; }
    }

    public class kasaAuthTokenResult
    {
        public string accountId { get; set; }
        public string regTime { get; set; }
        public string countryCode { get; set; }
        public int riskDetected { get; set; }
        public string email { get; set; }
        public string token { get; set; }
    }
}
