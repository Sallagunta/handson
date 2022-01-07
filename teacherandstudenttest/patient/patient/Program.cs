using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patient
{
    class Program
    {
        static void Main(string[] args)
        {
            outpatient outpatientobj = new outpatient();
            outpatientobj.patientdetails();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
