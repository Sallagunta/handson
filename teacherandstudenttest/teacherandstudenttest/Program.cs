using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacherandstudenttest
{
    class teststudentteacher
    {
        static void Main(string[] args)
        {
            person personobject = new person();
            personobject.greet();
            personobject.Setage(40);
            personobject.Setsec(3);
            //personobject.Setsec();
            student studentobject = new student();
            studentobject.greet();
            studentobject.Setage(19);
           // studentobject.Setsec(" ab);
            studentobject.showage();
            studentobject.Setsec(3);
            studentobject.Gotoclasses();
            //Console.WriteLine("sec:" + studentobject.Setsec(3));
            teacher teacherobject = new teacher();
            teacherobject.greet();
            teacherobject.Setage(25);
            teacherobject.showage();
            teacherobject.Explain();
            Console.ReadKey();

        }
    }
}
