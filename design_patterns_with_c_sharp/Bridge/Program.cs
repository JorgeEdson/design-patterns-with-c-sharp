using System;

namespace Bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bridge bridge = new Bridge();
            Random random = new Random();

            void Sort() 
            {
                if (random.Next(2)==1) 
                    bridge.attributeOne = new ConcreteImplementorAttributeOne1();
                else
                    bridge.attributeOne = new ConcreteImplementorAttributeOne2();

                if (random.Next(1, 3) == 1)
                    bridge.attributeOne.IAttributeTwo = new ConcreteImplementorAttributeTwo1();
                else if(random.Next(1,3) == 2)
                    bridge.attributeOne.IAttributeTwo = new ConcreteImplementorAttributeTwo2();
                else
                    bridge.attributeOne.IAttributeTwo = new ConcreteImplementorAttributeTwo3();
            }

            Console.WriteLine("Press ENTER to send");

            while (1>0) 
            {
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.KeyChar == 13)
                    Sort();


                Console.WriteLine();
                bridge.Show();
            }
        }
    }
}
