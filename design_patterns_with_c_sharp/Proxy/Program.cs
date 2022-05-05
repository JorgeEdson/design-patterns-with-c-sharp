using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxySubject proxy = new ProxySubject();
            Console.WriteLine(proxy.getPassword("321"));
            Console.WriteLine(proxy.Action());
            Console.WriteLine(proxy.getPassword("123"));
            Console.WriteLine(proxy.Action());
            Console.ReadKey();
        }
    }
}
