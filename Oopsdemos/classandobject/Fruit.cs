using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsdemos.classandobject
{
    class Fruit
    {
        //instance varibles
        public string name, colour;

        public Fruit(string name, string colour)
        {
            this.name = name;
            this.colour = colour;
        }

        public void FruitDetails()
        {
            Console.WriteLine("Fruit Name:{0} colour:{1}", name, colour);
        }

    }
}
