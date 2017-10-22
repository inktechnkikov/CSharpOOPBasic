using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Cat:Animal
    {
        private string name;
        private int age;
        private string color;

        public Cat(string name, int age, string color) :
            base()
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }
        private string Name { get; set; }
        private int Age { get; set; }
        private string Color { get; set; }
        public string sayHello()
        {
            return "Maywing";
        }
    }
}
