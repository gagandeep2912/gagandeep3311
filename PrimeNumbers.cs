using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class calculate
    {
        public static bool IsPrime(int num)
        {

            int count = 0;
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
          
            if (count == 2)
            {
            
                return true;
            }
            return false;
        }
    }
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
          bool ans=  calculate.IsPrime(a);
            Console.WriteLine("tHE GIVEN NUMBER "+a+" IS PRIMENUMBER? "+ans );
        }
        
    }
}
