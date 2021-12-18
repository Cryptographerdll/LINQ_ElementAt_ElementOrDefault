using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQ_ElementAt_ElementOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Fruits = new List<string>
            {
                "Banana", "Peer", "watermelon", "Pomme", "Orange", "Papoy"
            };

            var Element = Fruits.ElementAt(2);

            Console.WriteLine(Element);
        }
    }
}
