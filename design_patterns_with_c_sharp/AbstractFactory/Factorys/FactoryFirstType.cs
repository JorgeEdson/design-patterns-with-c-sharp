/* 
 * These codes are part of the demonstration of knowledge 
 * about programming techniques with the C# language 
 * by the developer Jorge Edson
 */

/*
 * @brief   Class that manufactures a Type and implements the IFactoryTypes interface 
 * @author  Jorge Edson
 * @date    2022.03.27
 */

using System;

namespace AbstractFactory.Factorys
{
    public class FactoryFirstType : IFactoryTypes
    {
        public FactoryFirstType()
        {
            createType();
        }

        public void createType()
        {
            Console.WriteLine("First Type was created!");
            var compositionX = new CompositionXFirstType();
            compositionX.ToCompose();
            var compositionY = new CompositionYFirstType();
            compositionY.ToCompose();
            var compositionZ = new CompositionZFirstType();
            compositionZ.ToCompose();
        }
    }
}
