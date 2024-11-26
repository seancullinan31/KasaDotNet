using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaLib.ResponseObjects
{

    public class kasaDeviceList
    {
        public int error_code { get; set; }
        public Result result { get; set; }
    }

    public class Result
    {
        public kasaDevice[] deviceList { get; set; }
    }

    

}
