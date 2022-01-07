using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace patient
{
    public class outpatient
    {
        public void patientdetails()
        {
            FileStream filestreamobj = new FileStream("c:\\new folder\\patient.txt", FileMode.Open, FileAccess.Write);
            StreamWriter stream = new StreamWriter(filestreamobj);
            Console.WriteLine("enter patient details");
            Console.WriteLine("enter name of the patient");
            string name = Console.ReadLine();
            Console.WriteLine("enter age of patient");
            string age = Console.ReadLine();
            Console.WriteLine("enter the patient id ");
            string id = Console.ReadLine();
            Console.WriteLine("enter the patient aadhar ");
            string aadhar = Console.ReadLine();


            Console.WriteLine("enter sample report positive \negative");
            string report = Console.ReadLine();
            stream.WriteLine(" patient name:=" + name);
            stream.WriteLine(" patient age:=" + age);
            stream.WriteLine(" patient id:=" + id);
            stream.WriteLine(" patient aadhar:=" + aadhar);
            stream.WriteLine("patient test report for omicron :=" + report);
            stream.Close();
            filestreamobj.Close();
            
            Console.WriteLine();
            Console.ReadKey();




        }
    }
}
