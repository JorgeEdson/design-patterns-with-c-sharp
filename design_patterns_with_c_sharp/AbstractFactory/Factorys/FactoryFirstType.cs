using System;
using System.Collections.Generic;
using System.Text;

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
