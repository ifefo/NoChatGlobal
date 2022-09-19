using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoChatGlobalRP
{
  public  class NoChatGlobalRPConfig : IRocketPluginConfiguration
    {
        public string mensaje;
        public void LoadDefaults()
        {
            mensaje = "No Puedes Escribir En Global";
        }
    }
}
