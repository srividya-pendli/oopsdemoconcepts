using Oopsdemos.Abstraction;
using Oopsdemos.classandobject;
using Oopsdemos.Encapuslation;
using Oopsdemos.Inheritance;
using Oopsdemos.Polymarphism;
using Oopsdemos.Polymarphism.methodoverride;
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
            Console.WriteLine("1:classandobject\n2:Inheritance\n3:methodoverload\n4:methodoverride\n5:Abstraction\n6:Encapuslation");
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
                    Car car = new Car();
                    car.brand = "BMW";
                    car.start();
                    break;
                case 3:
                    Addition addition = new Addition();
                    addition.Add(10, 20, 30);
                    break;
                case 4:
                    PartTimeEmpolyee partTime = new PartTimeEmpolyee();
                    partTime.empName = "nishu";
                    partTime.EmpolyeeDetails();
                    partTime.CalculateSalary();
                    break;
                case 5:
                    Dog dog = new Dog();
                    dog.animalsound();
                    dog.sleep();
                    break;
                case 6:
                    Account account = new Account();
                    //account.SetBalance(2000);
                    account.balance = -3000;
                    Console.WriteLine(account.GetBalance());
                    break;
                default:
                    Console.WriteLine("please choose number within range");
                    break;
            }
            Console.ReadLine();

        }
    
    }
}
