using System;

namespace ECS.Legacy
{
    public class ECS
    {
        private readonly TempSensor _tempSensor;
        private readonly Heater _heater;

        public ECS(int thr)
        {
            
            _tempSensor = new TempSensor();
            _tempSensor.SetThreshold(thr);
            _heater = new Heater();
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            Console.WriteLine($"Temperatur measured was {t}");
            if (t < _tempSensor._threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        //public int GetCurTemp()
        //{
        //    return _tempSensor.GetTemp();
        //}

        //public bool RunSelfTest()
        //{
        //    return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        //}
    }
}
