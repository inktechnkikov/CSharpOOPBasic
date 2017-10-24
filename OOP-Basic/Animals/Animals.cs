using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animals
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Stamat", "meat");
            Animal cat = new Cat("Pesho", "whiskas");

            List<Animal> animalList = new List<Animal>();
            animalList.Add(dog);
            animalList.Add(cat);

            animalList.ToList().ForEach(a => Console.WriteLine(a.printNameAndFavoriteFood()));
        }
    }
}
