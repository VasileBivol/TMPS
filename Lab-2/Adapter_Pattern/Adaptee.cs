using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Adaptee 
    {
        public int Rand(int limit)
        {
            Random random = new Random();
            int rnd_num = random.Next(0, limit);
            return rnd_num;
        }
    }
}
