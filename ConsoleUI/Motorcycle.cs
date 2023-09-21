﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle() 
        
        {
        }

        public bool HasSideCart { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcycle is currently in drive!");
        }

        public override void DriveVirtural()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} is driving virturally!");
        }
    }
}
