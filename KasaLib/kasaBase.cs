using KasaLib.InputObjects;
using KasaLib.ResponseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaLib
{
    public abstract class kasaBase
    {
        public const string BASE_URI = "https://wap.tplinkcloud.com";
        protected Uri BaseUri { get
            {
                return new Uri(BASE_URI); 
            } 
        }
        protected Uri TokenizedUri(kasaAuthToken authToken)
        {
            return new Uri(BASE_URI + "?token=" + authToken.result.token);
        }
    }
}
