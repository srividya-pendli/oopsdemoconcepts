using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsdemos.Abstraction
{
    class Dog:Animal
    {
        public override void animalsound()
        {
            //the body of animalsound is provided here
            Console.WriteLine("the dog says: boe bow");
        }
    }
}
