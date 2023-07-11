using CarParkProject_0506.Data;
using CarParkProject_0506.Data.Dto;
using CarParkProject_0506.Data.Services;
using System.Diagnostics;

namespace CarParkProject_0506.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carService = new CarParkService(new CarParkDataStore());

            //var results = carService.GetAutoByParameter<Bus>("Levels", "1");

            //foreach (var result in results)
            //{
            //    Console.WriteLine(result.GetDetails());
            //}

            var vehicle1 = new Bus
            {
                Levels = 1,
                Id = 4,
                Engine = new Engine
                {
                    Power = 200,
                    Volume = 200,
                    Type = EngineTypeEnum.Diesel,
                    SerialNumber = "dklahbjefghvj"
                },
                Transmission = new Transmission
                { 
                    NumberOfGears = 1,
                    Manufacturer = "BMW",
                    Type = TransmissionTypeEnum.Manual
                },
                Chassis = new Chassis 
                {
                    NumberOfWheels = 2,
                    Number = "erg4e25r4",
                    PermissibleLoad = 50
                }
            };
            
            //carService.AddVehicle(vehicle1);

            var vehicles = carService.GetAllVehicles();

            foreach (var vehicle in vehicles)
            { Console.WriteLine(vehicle.GetDetails());
                Console.WriteLine();
            }

            var lastVehicle = vehicles.LastOrDefault(v => v is Vehicle);
            Console.WriteLine("--------------------");
            Console.WriteLine(vehicles.Count());
            Console.WriteLine(lastVehicle.GetDetails());

            carService.RemoveVehicle(11);
            carService.RemoveVehicle(10);
            carService.RemoveVehicle(9);
            carService.RemoveVehicle(8);
            carService.RemoveVehicle(7);
            carService.RemoveVehicle(6);
            carService.RemoveVehicle(5);
            carService.RemoveVehicle(4);

            lastVehicle = vehicles.LastOrDefault(v => v is Vehicle);
            Console.WriteLine("--------------------");
            Console.WriteLine(vehicles.Count());
            Console.WriteLine(lastVehicle.GetDetails());


            Console.ReadKey();
        }
    }
}