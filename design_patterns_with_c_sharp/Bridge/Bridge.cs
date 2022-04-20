using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Bridge
    {
        public IAttributeOne attributeOne { get; set; }
        public void Show() 
        {
            Console.WriteLine(attributeOne.OperationFromOne());
        }
    }
}
