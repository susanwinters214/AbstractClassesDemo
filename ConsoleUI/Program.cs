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
                HasTrunk = true
            };
            var motorcycle1 = new Motorcycle()
            {
                HasSideCart= true
            };
            Vehicle vehicle1 = new Car() { Make = "Ford" };
            Vehicle vehicle2 = new Motorcycle() { Make = "Honda" };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
