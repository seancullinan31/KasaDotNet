using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaLib
{
    public abstract class kasaBase
    {
        protected Uri BaseUri { get
            {
                return new Uri("https://wap.tplinkcloud.com"); 
            } 
        }
    }
}
