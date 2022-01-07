using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "c:\\gowtham\\gowthami1.txt";
            StreamWriter streamwriterobj = new StreamWriter(file);
            streamwriterobj.Write(DateTime.Now.ToString());
            streamwriterobj.Close();
            Console.WriteLine();
            StreamReader streamreaderobj = new StreamReader(file);
           streamreaderobj.ReadToEnd();
            streamreaderobj.Close();
            Console.WriteLine();
            Console.ReadKey();
            
            
        }
    }
}
