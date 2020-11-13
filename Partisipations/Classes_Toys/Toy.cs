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
            string manufacturer = "";
            string name = "";
            double price = 0;
        }

        public string GetAisle() 
        {

        }

    }
}
