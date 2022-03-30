using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsdemos.Polymarphism.methodoverride
{

    public class Employee
    {


        public string empName, address;
        public int Id;

        public void EmployeeDetails()
        {
            Console.WriteLine("employee Name:{0}", empName);
        }
        public void CalculateSalary()
        {
            Console.WriteLine("5000");
        }
    }
}
