using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;
using AbstractFactoryAutomovil.mundo.clases;

namespace AbstractFactoryAutomovil.mundo.fabricas
{
    class FabricaBmw: IFabricaPartes
    {
        public IAuto crearAuto()
        {
            return new AutoBmw();
        }

        public IMotor crearMotor()
        {
            return new MotorBmw();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaBmw();
        }
    }
}
