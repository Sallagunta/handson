using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classconsole
{
    public class Base

    {
        public Base()
        {
            Console.WriteLine(" constructor is base");
        }
        public void DispalyMsg()
        {
            Console.WriteLine("how are you");

        }
    }
    public class child : Base
    {


        public child()
        {
            Console.WriteLine("constructor is child");

        }
        public void displaymsg()
        {
            Console.WriteLine("hiii");
        }

    }
    public class subchild:child
    {

        public void Getchilddetails()
        {
            Console.WriteLine("your in subchild constructor");
            
        }
    }
}
