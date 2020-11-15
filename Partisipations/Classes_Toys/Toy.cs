using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes { get; set; }


        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "This boardgame is really fun!";
        }

        public string GetAisle() 
        {
            Random rand = new Random();
            int index = rand.Next(1,25);

            return Manufacturer + index;
        }

    }
}
