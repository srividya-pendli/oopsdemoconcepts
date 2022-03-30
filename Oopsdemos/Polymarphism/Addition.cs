using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsdemos.Polymarphism
{
   public class Addition
    {
        public void Add(int x, int y)
        {
            int Z = x + y;
            Console.WriteLine("Sum:" + Z);
        }
        public void Add(int x, int y, int p)
        {
            int Z = x + y + p;
            Console.WriteLine("Sum:" + Z);
        }
        //changing datatype
        public void Add(double x, int y, int p)
        {
            double Z = x + y + p;
            Console.WriteLine("Sum:" + Z);
        }
        //changing order of parameters
        public void Add(int y, double x, int p)
        {
            double Z = x + y + p;
            Console.WriteLine("Sum:" + Z);
        }
    }
}
