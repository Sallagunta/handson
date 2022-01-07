using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacherandstudenttest
{
    public class person
    {
        public int age;
        public int  sec;
        public void greet()
        {
            Console.WriteLine("hello");
        }

        public void Setage(int n)
        {
            age = n;

        }
        public void Setsec(int  n)
        {
            sec = n;
            //return "n";
            
        }


    }

    public class student : person
    //public student()
    {
        public void Gotoclasses()
        {
            Console.WriteLine("i am going to class");
        }
        public string showage( )
        {
            Console.WriteLine("my age is :{0} years old" , age);
            return "age";
        }
        public void Setsec(int n)
        {
            sec = n;
            //return "n";
        }
    }
    public class teacher : person
    {
        public void Explain()
        {
            Console.WriteLine(" explanation begins");
        }
        private string subject;
        public void showage()
        {
            Console.WriteLine("my age is :{0} years old", age);
        }
    }
    
}
 


