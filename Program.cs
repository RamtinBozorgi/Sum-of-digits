using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Program
    {
        static void Main()
        {
            int s = 0;
            Console.WriteLine("Please enter the number:");
            string n = Console.ReadLine();
            int x = n.Length;
            if (x > 0)
            {
                for (int i = 0; i < x; i++)
                {

                    s += int.Parse(n[i].ToString());
                }
                Console.WriteLine("The sum of {0} digit of number {1} is: {2}.", x, n, s);

            }
            else
            {
                Console.WriteLine("At least 1 digit is essential.");
            }
            Console.ReadLine();
        }
    }
}
