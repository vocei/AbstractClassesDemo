using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           var vehicles = new List<Vehicle>();


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle


            Car mazda = new Car()
            {

                HasTrunk = true,
                Make = "Mazda",
                Model = "r8",
                Year = 2005
            };

            Motorcycle harley = new Motorcycle()
            {
                HasSideCart = true,
                Make = "Harley",
                Model = "Chopper",
                Year = 1995


            };

            Vehicle GNC = new Car()
            {HasTrunk = true, Make = "GNC", Model = "Ram", Year = 2024 };

            Vehicle bugg = new Car()
            {Make = "Bugatti", Model = "Veyron", Year = 2001 };

            
            vehicles.Add(mazda);
            vehicles.Add(bugg);
            vehicles.Add(GNC);
            vehicles.Add(harley);

            foreach (var veh in vehicles) 
            {
                Console.WriteLine(veh);
                Console.WriteLine($" Make: {veh.Make} Model: {veh.Model} Year: {veh.Year}");
                veh.DriveAbstract();
                Console.WriteLine($"\n");
            }

        }
    }
}
