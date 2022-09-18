using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy
{
    interface IHeater
    {
        public void TurnOn();
        public void TurnOff();
        public bool RunSelfTest();
    }
}
