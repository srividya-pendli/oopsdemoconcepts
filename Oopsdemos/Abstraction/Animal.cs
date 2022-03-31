using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsdemos.Abstraction
{
    //abstract class
     abstract class Animal
    {
        // abstract method (does not have a body)
        public abstract void animalsound();
        //Regualr method
        public void sleep()
        {
            Console.WriteLine("the animal sleep: aaaa");
        }

    }
}
