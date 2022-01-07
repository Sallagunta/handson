using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public class house
    {
        public void Showdata( string housearea,string doorcolour)
        {
            Console.WriteLine(" iam a house my area is : :"+housearea);
            Console.WriteLine("  i am a door my colour is:: "+ doorcolour);
           
        }
    }
    public class apartment : house
    {
        public void showdetails1()
        {
            Console.WriteLine("i am small apartment with area of 50 m^2");
        }


        public class person:apartment
        {
            public string persondetails(string name)
            {
             Console.WriteLine("")
            }
        }
    }
}
