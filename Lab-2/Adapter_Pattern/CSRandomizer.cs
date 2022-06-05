using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class CSRandomizer : Randomizer
    {
        private readonly Adaptee _csadaptee = new Adaptee();
        public int srand(int lim)
        {
            int result = _csadaptee.Rand(lim);
            return result;
        }
    }
}
