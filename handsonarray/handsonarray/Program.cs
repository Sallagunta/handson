using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsonarray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
          int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i, n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("elements are  the number of elements" ,n);
            for(i=0;i<n;i++)
            {
                Console.WriteLine("elements are {0}=", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("copied elements are");


            {
                arr2[i] = arr1[i];
                Console.WriteLine(arr2[i]);

            }
           // Console.WriteLine(arr2[i]);
            Console.WriteLine('\n');
           
            Console.ReadKey();

            
        }   
    }
}






































           
        
    

