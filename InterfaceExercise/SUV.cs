﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public string DriveType { get; set; }
        public bool IsDriveable { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public double StockPrice { get; set; }
    }
}
