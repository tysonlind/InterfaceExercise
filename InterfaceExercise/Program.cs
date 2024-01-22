using System;
using System.IO;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            Car hondaCivic = new Car() { MPG = 36, Type = "Sedan", Logo = "Honda thing", Make = "Honda", Model = "Civic", NumberOfSeats = 4, NumberOfWheels = 4, StockPrice = 113.94 };
            SUV chevroletEquinox = new SUV() { DriveType = "AWD", IsDriveable = true, Logo = "Honda thing", Make = "Honda", Model = "Civic", NumberOfSeats = 4, NumberOfWheels = 4, StockPrice = 113.94 };
            Truck fordF150 = new Truck() { CarryingWeightLimit = 14000, OwnedByTruckEnthusiast = false, Logo = "Honda thing", Make = "Honda", Model = "Civic", NumberOfSeats = 4, NumberOfWheels = 4, StockPrice = 113.94 };

            Console.WriteLine($"Our selection of vehicles you can purchase includes:\nChevrolet Equinox, with {chevroletEquinox.DriveType}\nFord F-150 with a carrying limit of {fordF150.CarryingWeightLimit} pounds\nHonda Civic, with an impressive MPG of {hondaCivic.MPG}");
        }
    }
}
