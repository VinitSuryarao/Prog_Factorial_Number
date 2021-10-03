using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        //   Factorial Number
        //   Number = 5
        //   Factorial = 5 * 4 * 3 * 2 * 1

        static void Main(string[] args)
        {
            int n, fact;
            n = 5;
            fact = n;

            for (int i= n-1; i>=1; i--)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial Number is " + fact.ToString());
            Console.ReadLine();
        }
    }


