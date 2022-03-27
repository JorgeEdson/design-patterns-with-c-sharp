/* 
 * These codes are part of the demonstration of knowledge 
 * about programming techniques with the C# language 
 * by the developer Jorge Edson
 */

/*
 * @brief   Implementation of the ICompositionX Interface
 * @author  Jorge Edson
 * @date    2022.03.27
 */

using System;

namespace AbstractFactory
{
    public class CompositionYFirstType : ICompositionY
    {
        public void ToCompose()
        {
            Console.WriteLine("This is composition Y of the First Type");
        }
    }
}
