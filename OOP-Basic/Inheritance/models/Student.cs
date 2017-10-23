using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student : BasePerson
    {
        private string school;
        
        public Student(string name, string address,string school) :
            base(name, address)
        {
            this.school = school;
        }

       public void print()
        {
            Console.WriteLine(base.getInfo() + " in " + this.school);
        }
    }
}
