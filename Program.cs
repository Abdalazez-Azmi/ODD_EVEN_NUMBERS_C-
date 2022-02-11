using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ODD || Even Number

            int x;
            x = Convert.ToInt16(Console.ReadLine());
            if (x%2 == 0)
            {
                Console.WriteLine("Number " + x + " is Even Number ");
            }
            else
            {
                Console.WriteLine("Number " + x + " is Odd Number ");

            }
            Console.ReadLine();




        }
    }
}
