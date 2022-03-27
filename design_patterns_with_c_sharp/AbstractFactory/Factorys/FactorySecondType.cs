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
    public class FactorySecondType : IFactoryTypes
    {
        public FactorySecondType()
        {
            createType();
        }

        public void createType()
        {
            Console.WriteLine("Second Type was created!");
            var compositionX = new CompositionXSecondType();
            compositionX.ToCompose();
            var compositionY = new CompositionYSecondType();
            compositionY.ToCompose();
            var compositionZ = new CompositionZSecondType();
            compositionZ.ToCompose();
        }
    }
}
