using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandson
{
    class Program
    {
        static void Main(string[] args)
        {//file creation
            FileStream filestreamobj = new FileStream("c:\\gowtham\\gowthami1.txt", FileMode.Create, FileAccess.Write);
            //aading current date and time to string
            //byte[] bdata = Encoding.Default.GetBytes(DateTime.Now.ToString());
            //DateTime data = Convert.ToDateTime(Console.ReadLine());
           Console.WriteLine(DateTime.Now);
            Console.WriteLine( DateTime.Now.ToLongTimeString());
            //filestreamobj.Write(bdata, 0, bdata.Length);
            Console.WriteLine("data added");
            filestreamobj.Close();
            //read the file
           // string data;
            FileStream filestreamobject = new FileStream("c:\\gowtham\\gowthami1.txt", FileMode.Open,FileAccess.Read);
            StreamReader streamreaderobj = new StreamReader(filestreamobject);
            streamreaderobj.ReadToEnd();
            Console.WriteLine();
            Console.ReadKey();


            



        }
    }
}
