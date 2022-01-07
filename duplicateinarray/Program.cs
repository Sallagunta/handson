using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicateinarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] dup = new int[100];
            int i, j, n, cnt = 1
                ;
            Console.WriteLine("enter value of n");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("elements are=", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    cnt = 1;
                    if (arr1[i] == arr1[j])
                    {
                        cnt++;
                        dup[ j]=0;
                    }
                    if(dup[i]!=0)
                    {
                        dup[i]=cnt;
                    }

                }

               // Console.WriteLine("duplicates are");

            }
            Console.WriteLine("duplicates are");
            for (i=0;i<n;i++)
            {
               //Console.WriteLine("duplicates are");
                if(dup[i]>2)
                {
                    Console.WriteLine(arr1[i]+"");
                }
            }
           
            Console.ReadKey();


        }
        
    }
   
}        
        
    
    

