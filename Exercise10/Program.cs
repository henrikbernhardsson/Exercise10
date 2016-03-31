using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData v = new VehicleData();
            string frameMaterial;
            string engine;
            string manufacturer;
            Console.WriteLine(@"1. Create a new car.
2. Create a new bicycle.");
            string _switch = Console.ReadLine();
            switch (_switch)
            {
                case "1":
                    Console.Write("Enter type of engine: ");
                    engine = Console.ReadLine();
                    Console.Write("Enter car manufacturer: ");
                    manufacturer = Console.ReadLine();
                    var _car = new Car(engine, manufacturer, false);
                    _car.StartEngine();
                    _car.StopEngine();
                    v.PrintVehicle(_car);
                    break;
                case "2":
                    Console.Write("Enter the frame material of the bicycle: ");
                    frameMaterial = Console.ReadLine();
                    Bicycle _bicycle = new Bicycle(frameMaterial);
                    v.PrintVehicle(_bicycle);
                    break;
                default:
                    break;
            }



           
            
            Console.ReadKey();
        }
    }
}
