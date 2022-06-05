using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Randomizer randomizer = new CSRandomizer();
            Console.Write("Type a number greater than 0 > ");
            int dec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Random number between 0 and {dec} > " + randomizer.srand(dec));
        }
    }
}