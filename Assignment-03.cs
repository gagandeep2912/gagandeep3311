using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Assignment_03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter the "+size+" elements of array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++) { 
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine(array[i]+"is even number");
                }
                else
                {
                    Console.WriteLine(array[i]+"is odd number");
                }
            }


        }
        
    }
}
