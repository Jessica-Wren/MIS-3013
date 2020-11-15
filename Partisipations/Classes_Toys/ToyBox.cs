using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Toys
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }     // defining: in order to be a toybox, you need to be a collection of things


        public ToyBox()
        {
            Toys = new List<Toy>();           // this says: this thing that we are calling toys, set that to a new instance of toys
        }

        /*public Toy GetRandomToy() 
        {
            
            Random rand = new Random();
            int index = rand.Next(1,3);
            return Toy;
            
            
        }*/
    }
}
