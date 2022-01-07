using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter num 1");
            num1 = Convert. ToInt32 (Console.ReadLine());
            Console.WriteLine("enter num 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} ={2}" , num1 , num2,  num1 + num2);
            Console.ReadKey();

        }
    }
}
