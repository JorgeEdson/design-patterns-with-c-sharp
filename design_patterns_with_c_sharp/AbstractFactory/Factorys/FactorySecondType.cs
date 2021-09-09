using System;
using System.Collections.Generic;
using System.Text;

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
