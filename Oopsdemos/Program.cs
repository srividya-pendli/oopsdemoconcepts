using Oopsdemos.classandobject;
using Oopsdemos.Polymarphism;
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
            Console.WriteLine("1:classandobject\n2:Inheritance\n3:methodoverload\n4:methodoverride");
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
                case 2:
                    car car = new .car();
                    car.brand = "BMW";
                    car.start();
                    break;
                case 3:
                    Addition addition = new Addition();
                    addition.Add(10, 20, 30);
                    break;
                case 4:
                    PartTimeEmployee partTime = new PartTimeEmployee();
                    partTime.empName = "srividya";
                    partTime.calculatesalary();
                    break;
                default:
                    Console.WriteLine("please choose number within range");
                    break;
            }
            Console.ReadLine();

        }
    
    }
}
