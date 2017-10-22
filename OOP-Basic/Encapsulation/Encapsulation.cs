using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Encapsulation
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("pesho", 2, "orange");
            Cat cat = new Cat("pesho", 1, "white");
            Console.WriteLine(cat.NumberOfLegs);
        }
    }
}
