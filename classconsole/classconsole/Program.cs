using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            subchild childobject = new subchild();
            childobject.Getchilddetails();
            bike bikeobject = new bike();
            bikeobject.Getmilege();

            bikeobject.Getcolour();
            //child childobject = new child();
            //childobject.displaymsg();


            


             Console.WriteLine (bikeobject.Getmilege());

             Console.WriteLine(bikeobject.Getcolour());
           // Console.WriteLine(bikeobject.Getformula));
           // Console.WriteLine(Getcolour);
          //  Console.WriteLine(Getmilege);++
            Console.ReadKey();

        }
    }
}
