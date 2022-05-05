using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class ProxySubject : ISubject
    {
        RealSubject realSubject;
        string password = "123";
        
        public string Action()
        {
            if (realSubject != null)
                return realSubject.Action();

            return "Inform the  correct password";
        }

        public string getPassword(string cod) 
        {
            if (cod == password) 
            {
                realSubject = new RealSubject();
                return "Correct Password";
            }

            return "Wrong Password";
        }        
    }
}
