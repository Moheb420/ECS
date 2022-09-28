using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy
{
    public class FakeHeater:IFakeHeater
    {
       

        bool IFakeHeater.FakeTurnOn(int i)
        {
            if (i == 1)
            {
                return true;
            }
            else if (i == 2)
            {
                return false;
            }

            return false;

        }
    }
}
