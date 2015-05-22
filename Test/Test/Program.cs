using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where you born in a  Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("No you were not born in a leap year.");
            }
            else
            {
                Console.WriteLine("Yes you were born in a leap year.");
            }

            Console.ReadLine();

        }
    }
}
