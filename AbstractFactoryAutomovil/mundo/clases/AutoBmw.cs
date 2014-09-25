using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;

namespace AbstractFactoryAutomovil.mundo.clases
{
    class AutoBmw: IAuto
    {
        public string darNombre()
        {
            return "Auto Bmw";
        }
    }
}
