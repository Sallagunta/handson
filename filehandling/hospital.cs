using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class hospital
    {
        public void doctor()
        {
            FileStream filestreamobj = new FileStream("c:\\new\\my file.txt", FileMode.Create, FileAccess.Write);
            StreamWriter swobj = new StreamWriter(filestreamobj);
            swobj.WriteLine("welcome to my hospital");
            Console.WriteLine("enter doctor name");
            string name = Console.ReadLine();
            Console.WriteLine("doctorname:=" + name);
            swobj.WriteLine( "doctor name"+name);
            Console.WriteLine("enter hospital name");
            string hosptname = Console.ReadLine();
            Console.WriteLine("hosptname:=" + hosptname);
            swobj.WriteLine( "hospital name"+hosptname);
            Console.WriteLine("enter doctor ID");
            string Id = Console.ReadLine();
            Console.WriteLine("ID number:=" + Id);
            swobj.WriteLine( "idnum"+Id);
            Console.WriteLine("enter doctor specialization");
            string specialist = Console.ReadLine();
            Console.WriteLine("specialization:=" + specialist);
            swobj.WriteLine( "specialization"+specialist);
            swobj.Close();
            filestreamobj.Close();
        }
            
    }
}
