using System;

namespace ECS.Legacy
{
    internal class TempSensor:ITempSensor
    {
        public int _threshold;
        public TempSensor _TempSensor;
        private Random gen = new Random();

        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;
        }
        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }
    }
}