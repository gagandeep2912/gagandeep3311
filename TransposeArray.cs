using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{


    class CreateArray { 
        public static void Arrays(int size1,int size2)
    {
            
           
            int[,] ar =new int[size1,size2];
            Console.WriteLine("Array created");
           
            Console.WriteLine("Eneter the values for the array");
            for(int i = 0; i<ar.GetLength(0); i++)
            {
               
                for(int j = 0; j <ar.GetLength(1); j++)
                {
                   //Console.WriteLine(j);
                   // Console.WriteLine(i);
                    ar[i,j] = Convert.ToInt32(Console.ReadLine());

                }

            }
            Console.WriteLine("The given array");
            for (int i = 0; i < ar.GetLength(0); i++)
            {

                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.Write(ar[i,j]+" ");
                }
                Console.WriteLine();
              
            }
            Console.WriteLine("The converted array");
            for (int i = 0; i < ar.GetLength(0); i++)
            {

                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.Write(ar[j, i] + " ");
                }
                Console.WriteLine();
               
            }




        }

    }

    class TransposeArray
    {
        static void Main(string[] args)
        {

            int[,] ar = { { },{ } };

            Console.WriteLine("enter the size1");
           int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the size2");
           int b = Convert.ToInt32(Console.ReadLine());

       
            CreateArray.Arrays(a,b);
        }
       
        
    }
}
