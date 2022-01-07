using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandson3
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "c:\\gowtham\\gowthami1.txt";
            //to ctreat file
            TextWriter text = File.CreateText(file);
            text.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("date and time is saved");
            text.Close();
            TextReader reader = File.OpenText(file);
            reader.ReadToEnd();
           
            reader.Close();
            Console.WriteLine();
            Console.ReadKey();
           
        }
    }
}
