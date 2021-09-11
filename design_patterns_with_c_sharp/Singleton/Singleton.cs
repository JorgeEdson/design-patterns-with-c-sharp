using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;        

        public static Singleton GetInstance
        {
            get 
            {
                if (instance == null) 
                {
                    instance = new Singleton();
                    Console.WriteLine("New Object Singleton Started");                
                }

                return instance;
            }
        }

        public static void DisposeInstance()
        {
            instance = null;
            Console.WriteLine("The instance was destroyed");
        }

        public void isInstanceWhithMe(string nameObject) 
        {
            if (instance != null)
            {
                Console.WriteLine("The instance at this moment belongs to the object: " + nameObject);
            }
            else
            {
                Console.WriteLine(nameObject+" says: There is no instance");
            }            
        }        
    }
}
