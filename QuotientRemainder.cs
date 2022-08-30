using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class QuotientReminder
    {
       
        public void QuoRem()
        {
            Console.WriteLine("Enter the value of dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("quotient = " + quotient);
            Console.WriteLine("remainder = " + remainder);
        }
    }
}
