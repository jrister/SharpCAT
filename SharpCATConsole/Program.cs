﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpCATLib;

namespace SharpCATConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpCAT sharpCAT = new SharpCAT();
            Console.WriteLine("Ports found: ");
            foreach (var port in sharpCAT.PortNames)
            {
                Console.WriteLine(port);
            }
            
            Console.ReadKey();
        }
    }
}