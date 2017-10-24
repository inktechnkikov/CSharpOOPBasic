using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
   public class Animal
    {
        private string  name;
        private string favFood;

        public string FavFood
        {
            get { return this.favFood; }
            set { favFood = value; }
        }
        public string  Name
        {
            get { return this.name; }
            set { name = value; }
        }
        public string printNameAndFavoriteFood()
        {
            return $"i am {this.Name} and my favorite food is {this.FavFood}";
        }

    }
}
