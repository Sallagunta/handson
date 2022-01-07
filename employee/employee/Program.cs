using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            string  email = Console.ReadLine();
            int  salamt = Convert.ToInt32( Console.ReadLine());
             int  salcutin =Convert. ToInt32(Console.ReadLine());

            empldetails empldetailsobj = new empldetails();
            empsalary empsalaryobj = new empsalary();
             empldetailsobj.Selfinformation(fname,lname,email);
            empsalaryobj.salaryinformation(salamt,salcutin );
            Console.ReadKey();
        }
        
    }
}
