using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class RootManager
    {
        private Dictionary<string, Root> roots = new Dictionary<string, Root>();

        public Root this[string key]
        {
            get { return roots[key]; }
            set { roots.Add(key, value); }
        }
    }
}
