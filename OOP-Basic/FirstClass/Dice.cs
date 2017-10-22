using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
   public class Dice
    {
        private int size { get; set; }
        private string color { get; set; }

        public Dice(int size, string color)
        {
            this.size = size;
            this.color = color;
        }
        public void getDiceInfo()
        {
            Console.WriteLine(this.size + " " + this.color);
        }
    }
}
