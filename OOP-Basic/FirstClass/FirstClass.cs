using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class FirstClass
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice(6, "red");
            dice.getDiceInfo();
        }
    }
}
