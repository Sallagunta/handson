using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printing_name
{
    public  class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.WriteLine("enter the value of a,b,c");
            a = int.Parse(Console.ReadLine());
           // Console.WriteLine("enter the value of b");
            b = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the value of c");
            c = int.Parse(Console.ReadLine());

            c = a * b * c;
           // Console.WriteLine("after swappinga=" + a);//+ "b="  +b);
            Console.WriteLine("mul=" + c);
           //SConsole.WriteLine(b);




           Console.ReadKey();


           
        }
    }
}
