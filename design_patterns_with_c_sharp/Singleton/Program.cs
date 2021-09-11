using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton firstObject = Singleton.GetInstance;
            firstObject.isInstanceWhithMe(nameof(firstObject));

            Singleton SecondObject = Singleton.GetInstance;
            SecondObject.isInstanceWhithMe(nameof(SecondObject));

            Singleton ThirdObject = Singleton.GetInstance;
            ThirdObject.isInstanceWhithMe(nameof(ThirdObject));

            Singleton.DisposeInstance();

            firstObject.isInstanceWhithMe(nameof(firstObject));
            SecondObject.isInstanceWhithMe(nameof(SecondObject));
            ThirdObject.isInstanceWhithMe(nameof(ThirdObject));


        }
    }
}
