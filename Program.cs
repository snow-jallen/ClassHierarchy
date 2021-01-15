using System;

namespace ClassHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var motorVehicle = new Car("Ford", "F-150");
            var car2 = new Car()
            {
                Make = "Ford",
                Model = "Taurus",
                MaxOccupants = 5
            };

            var car3 = new Car();
            car3.Make = "Ford";
            car3.Model = "Mustang";
            car3.MaxOccupants = 2;

            var mountainBike = new Bicycle();
            Console.WriteLine($"Number of vehicles created: {Vehicle.NumberOfVehiclesCreated}");
        }
    }
}
