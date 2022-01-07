using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructortry
{
    class Program
    {
        static void Main(string[] args)
        {
            teacher teacherobj = new teacher();
            Console.ReadKey();
               
        }
    }
    public class teacher
    {
        public teacher()
        {
            Console.WriteLine("my program");
        }
        public teacher(int age,string name)
        {
            Console.WriteLine("enter age");
           age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
        }
    }
}
