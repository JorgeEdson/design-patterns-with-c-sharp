﻿using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.OperationA();
            facade.OperationB();

            Console.ReadKey();
        }
    }
}
