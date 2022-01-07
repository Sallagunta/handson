using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehanson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "c:\\file\\file text.txt";
            StreamWriter streamwriterobj = new StreamWriter(file);
            streamwriterobj.Write(DateTime.Now.ToString());
            Console.WriteLine("data added");
            Console.ReadKey();
            StreamReader streamreaderobj = new StreamReader(file);
              
            Console.WriteLine(streamreaderobj.ReadToEnd());
            Console.ReadKey();
        }
    }
}
