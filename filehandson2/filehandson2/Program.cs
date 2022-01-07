using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "c:\\myfolder\\stream.txt";
            StreamWriter streamwriterobj = new StreamWriter(file);
            streamwriterobj.Write(DateTime.Now.ToString());
            Console.WriteLine("data added");
            Console.ReadKey();
            StreamReader streamreaderobj = new StreamReader(file);
            streamreaderobj.ReadToEnd();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
