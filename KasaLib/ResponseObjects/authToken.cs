using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaLib.ResponseObjects
{


    public class authToken
    {
        public int error_code { get; set; }
        public authTokenResult result { get; set; }
    }

    public class authTokenResult
    {
        public string accountId { get; set; }
        public string regTime { get; set; }
        public string countryCode { get; set; }
        public int riskDetected { get; set; }
        public string email { get; set; }
        public string token { get; set; }
    }
}
