using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_functions_csharp
{
    class Class1
    {
        public void sum_calc()
        {
            Console.Write("Enter the first number of your choice to add : ");
            int firstnum = Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondnum = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Sum is " + (firstnum + secondnum));
            
        }
    }
}
