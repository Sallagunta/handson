using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i, n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of elements to be passesed", n);
            for (i=0;i<n;i++)
            {
                Console.WriteLine("elements are{0}-", i);
                arr1[i] =Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("elements of first array");
            for(i=0;i<n;i++)
                Console.WriteLine(arr1[i]);
            for (i = 0; i < n; i++)
                arr2[i] = arr1[i];
            Console.WriteLine("elements of arr 2");
            for (i = 0; i < n; i++)
                Console.WriteLine(arr2[i]);

            Console.WriteLine('\n');
            Console.ReadKey();


        }
    }
}
