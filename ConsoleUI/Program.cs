using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Vehicles

           // Create a list of Vehicle called vehicles
           var vehicles = new List<Vehicle>();

            

            var car1 = new Car()
            {
                HasTrunk = true,
                Year = "2023",
                Make = "Honda",
                Model = "Accord"
            };
            var motorcycle1 = new Motorcycle()
            {
                HasSideCart= true,
                Year = "2019",
                Make = "Kawaski",
                Model = "Ninja"
            };
            Vehicle vehicle1 = new Car() {
                HasTrunk = true,
                Year = "2020",
                Make = "Ford",
                Model = "Focus"
            };
            Vehicle vehicle2 = new Motorcycle() {
                HasSideCart= true,
                Year = "2010",
                Make = "Suzuki",
                Model = "GSXR"
            };

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
           vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} " );
                Console.WriteLine($"Make: {vehicle.Make} ");
                Console.WriteLine($"Model: {vehicle.Model} ");
                Console.WriteLine();
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine();

            }

            // Call each of the drive methods for one car and one motorcycle



            #endregion            
         
        }
    }
}
