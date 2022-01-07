using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace employee
{
     public class empldetails
    {
        public string Selfinformation(string fname,string lname,string email)
        {
            Console.WriteLine(" fname :" +  fname);
            Console.WriteLine("lname :" + lname);
            Console.WriteLine("email:" + email);
            
            return "self details accessed";
        }
       

    }
}
