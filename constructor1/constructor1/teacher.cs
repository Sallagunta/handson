using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor1
{
    class teacher
    {
        public teacher()
        {
            Console.WriteLine("i am teaching 6th standard");
        }
        public teacher(int age, string name)
        {
               age =Convert.ToInt32( Console.ReadLine());
              name = Console.ReadLine();
            Console.WriteLine("your age and name");
        }

    }
  
}

