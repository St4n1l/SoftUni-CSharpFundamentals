using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "End")
                {
                    break;
                }

                VehicleType vehicleType;
                bool isVehicleTypeSuccessful = Enum.TryParse(input[0], true, out vehicleType);

                if (isVehicleTypeSuccessful)
                {
                    string vehicleModel = input[1];
                    string vehicleColour = input[2];
                    int vehicleHorsePower = int.Parse(input[3]);

                    var curVehicle = new Vehicle(vehicleType, vehicleModel, vehicleColour, vehicleHorsePower);
                    vehicles.Add(curVehicle);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Close the Catalogue")
                {
                    break;
                }

                var desiredVehicle = vehicles.FirstOrDefault(vehicle => vehicle.Model == command);

                Console.WriteLine(desiredVehicle);
            }

            var cars = vehicles.Where(vehicle => vehicle.Type == VehicleType.Car).ToList();
            var trucks = vehicles.Where(vehicle => vehicle.Type == VehicleType.Truck).ToList();

            double averageHPCars = cars.Count > 0 ? cars.Average(car => car.HorsePower) : 0.00;
            double averageHPTrucks = trucks.Count > 0 ? trucks.Average(truck => truck.HorsePower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {averageHPCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHPTrucks:f2}.");

        }
    }

    enum VehicleType
    {
        Car,
        Truck
    }

    class Vehicle
    {
        public Vehicle(VehicleType type, string model, string colour, int horsepower)
        {
            Type = type;
            Model = model;
            Colour = colour;
            HorsePower = horsepower;
        }
        public VehicleType Type { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Colour}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().Trim();
        }
    }
}
