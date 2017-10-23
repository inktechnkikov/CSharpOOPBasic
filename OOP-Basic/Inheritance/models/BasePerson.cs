using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BasePerson
    {
        private string name;
        private string address;

        public BasePerson(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public string Name
        {
            get { return this.name; }
        }
        public string Address
        {
            get { return this.address; }
        }
        public string getInfo()
        {
            return this.name + " from " + this.address;
        }
    }
}
