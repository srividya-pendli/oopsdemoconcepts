using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsdemos.Polymarphism.methodoverride
{
    class PartTimeEmpolyee:Empolyee
    {
        public new void CaluculateSalary()
        {
            Console.WriteLine("2000");
        }
    }
}
