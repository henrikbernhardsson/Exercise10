using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Car : Vehicle
    {
        public string EngineType { get; set; }
        public string Manufacturer { get; set; }
        public bool EngineIsRunning = false;
        public Car(string _engineType, string _manufacturer, bool _engineIsRunning) : base("Car")
        {
            this.EngineType = _engineType;
            this.Manufacturer = _manufacturer;
            this.EngineIsRunning = _engineIsRunning;
        }
        public void StartEngine()
        {
            EngineIsRunning = true;
        }
        public void StopEngine()
        {
            EngineIsRunning = false;
        }
    }
}
