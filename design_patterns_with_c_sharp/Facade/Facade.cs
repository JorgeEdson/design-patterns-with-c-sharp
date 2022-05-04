using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Facade
    {
        private SubSystemOne subSystemOne;
        private SubSystemTwo subSystemTwo;
        private SubSystemThree subSystemThree;

        public Facade()
        {
            subSystemOne = new SubSystemOne();
            subSystemTwo = new SubSystemTwo();
            subSystemThree = new SubSystemThree();
        }

        public void OperationA() 
        {
            Console.WriteLine("\nOperationA ----------");
            subSystemOne.Responsability();
            subSystemTwo.Responsability();
        }

        public void OperationB()
        {
            Console.WriteLine("\nOperationB ----------");
            subSystemThree.Responsability();
        }
    }
}
