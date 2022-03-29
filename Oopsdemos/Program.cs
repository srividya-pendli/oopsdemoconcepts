using Oopsdemos.classandobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsdemos
{
    class Program
    {
        public static object PartTime { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to oops");
            Console.WriteLine("1:classandobject");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    // code block
                    Fruit apple = new Fruit("apple", "red");
                    apple.FruitDetails();
                    Fruit orange = new Fruit("orange", "yellow");
                    orange.FruitDetails();
                    break;
                default:
                    Console.WriteLine("please choose number within range");
                    break;
            }
            Console.ReadLine();

        }
    
    }
}
