using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Animal
    {
        private int numberOfLegs;

        public Animal()
        {
            this.numberOfLegs = 4;
        }
        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            private set { this.numberOfLegs = value; }
        }
    }
}
