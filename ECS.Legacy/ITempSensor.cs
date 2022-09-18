using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy
{
    interface ITempSensor
    {
        public int GetTemp();
        public bool RunSelfTest();
        public void SetThreshold(int thr);
        public int GetThreshold();
    }
}
