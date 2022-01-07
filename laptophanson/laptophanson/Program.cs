using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptophanson
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string name = Console.ReadLine();
            string price = Console.ReadLine();
            string processor = Console.ReadLine();
            string Ram = Console.ReadLine();
            string harddrive = Console.ReadLine();*/
            sublap sublapobj = new sublap();
            sublapobj.lapdetl(1,"black");
            // sublapobj.laptopfeatures(name, price, processor, Ram, harddrive);

            sublapobj.laptopfeatures1("lenovo", "1000$", "i3", "2Gb", "500Gb");
            Console.WriteLine('\n');
            sublapobj.laptopfeatures2("hp", "1005$", "i3core", "2Gb", "500Gb");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
