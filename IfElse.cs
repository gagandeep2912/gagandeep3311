using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{


    class IfElse
    {
        static void Main(string[] args)
            
        {
            int countnum = 0, countvar=0, countspl=0;
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            char[] c = str.ToCharArray();
            for(int i = 0; i < str.Length; i++)
            {
                char character = c[i];
                if(character>='0' && character <='9')
                {
                    
                    countnum++;
                }
                else if(character >= 'A' && character <= 'Z' || character>= 'a' && character <= 'z')
                {
                    countvar++;
                }
                else 
                {
                    countspl++;
                }

            }
            Console.WriteLine("The number of digits present are:"+countnum);
            Console.WriteLine("The number of alphabets present are:" + countvar);
            Console.WriteLine("The number of sprcial characters p present are:" + countspl);
            

        }

    }
}
