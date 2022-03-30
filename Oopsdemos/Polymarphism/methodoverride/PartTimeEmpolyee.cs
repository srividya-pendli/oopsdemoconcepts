using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsdemos.Polymarphism.methodoverride
{
    public class PartTimeEmpolyee : Employee
    {
        public void CaluculateSalary()
        {
            Console.WriteLine("2000");
        }
    }
}
