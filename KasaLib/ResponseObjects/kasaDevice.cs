using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaLib.ResponseObjects
{
    public class kasaDevice
    {
        public string deviceType { get; set; }
        public int role { get; set; }
        public string fwVer { get; set; }
        public string appServerUrl { get; set; }
        public string deviceRegion { get; set; }
        public string deviceId { get; set; }
        public string deviceName { get; set; }
        public string deviceHwVer { get; set; }
        public string alias { get; set; }
        public string deviceMac { get; set; }
        public string oemId { get; set; }
        public string deviceModel { get; set; }
        public string hwId { get; set; }
        public string fwId { get; set; }
        public bool isSameRegion { get; set; }
        public int status { get; set; }
    }
}

