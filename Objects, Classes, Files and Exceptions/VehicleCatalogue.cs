using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Catalogue
{
    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalogue
    {
        static void Main()
        {
            var cars = new List<Car>();
            var trucks = new List<Truck>();

            ReadVehicles(cars, trucks);
            PrintTheCatalogue(cars, trucks);

            double avgCarsHorsePower = GetCarsHorsePower(cars);
            double avgTrucksHorsePower = GetTrucksHorsePower(trucks);

            Console.WriteLine($"Cars have average horsepower of: {avgCarsHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTrucksHorsePower:f2}.");
        }

        private static double GetTrucksHorsePower(List<Truck> trucks)
        {
            double avg = 0.0;
            if (trucks.Count > 0)
            {
                foreach (var truck in trucks)
                {
                    avg += truck.HorsePower;
                }

                avg = avg / trucks.Count;
            }
            return avg;
        }

        private static double GetCarsHorsePower(List<Car> cars)
        {
            var avg = 0.0;

            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    avg += car.HorsePower;
                }

                avg = avg / cars.Count();
            }
            return avg;
        }

        static void ReadVehicles(List<Car> cars, List<Truck> trucks)
        {
            var input = Console.ReadLine();

            while(input != "End")
            {
                var vehicleTokens = input.Split(' ').ToArray();
                var type = vehicleTokens[0].ToLower();
                var model = vehicleTokens[1];
                var color = vehicleTokens[2];
                var horsePower = int.Parse(vehicleTokens[3]);

                switch (type)
                {
                    case "car":
                        Car car = new Car();
                        car.Model = model;
                        car.Color = color;
                        car.HorsePower = horsePower;
                        cars.Add(car);
                        break;
                    case "truck":
                        Truck truck = new Truck();
                        truck.Model = model;
                        truck.Color = color;
                        truck.HorsePower = horsePower;
                        trucks.Add(truck);
                        break;
                }

                input = Console.ReadLine();
            }
        }

        static void PrintTheCatalogue(List<Car> cars, List<Truck> trucks)
        {
            var input = Console.ReadLine();

            while(input != "Close the Catalogue")
            {
                foreach (var car in cars)
                {
                    if(car.Model == input)
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                        break;
                    }
                }
                foreach (var truck in trucks)
                {
                    if(truck.Model == input)
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                        break;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
