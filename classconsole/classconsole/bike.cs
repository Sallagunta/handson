using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classconsole
{
    public class bike
    {
        public string colour;
        public string engine;
        public string milege;
         //private string formula="a*b";
        public string Getcolour()
        {
            return "red";
        }
        public string Getmilege()
        {
            return "65";
        }
        private string formula;// = "a*b";
        private string Getformula()
        {
                 formula = "a*b";
            return  formula;
        }
    }
}       
        
       
 

