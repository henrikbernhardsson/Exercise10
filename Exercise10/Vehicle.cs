using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Vehicle
    {
        public string TypeOfVehicle { get; set; }

        public Vehicle(string _typeOfVehicle)
        {
            TypeOfVehicle = _typeOfVehicle;
        }
        public string DescribeVehicle()
        {
            return ("This is an: " + TypeOfVehicle); 
        }

    }
}
