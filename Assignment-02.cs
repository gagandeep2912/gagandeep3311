using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Assignment_02
    {
        static void Main(string[] args)
        {
            while ( true){
                Console.WriteLine("-----------------------------------------------");
                double result = 0;

                Console.WriteLine("Enter a number");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the opeartion");
                string op = Console.ReadLine();
                Console.WriteLine("Enter another number");
                double b = Convert.ToDouble(Console.ReadLine());
                int c = 0;


                switch (op)
                {
                    case "+":
                        {
                            result = a + b;
                            break;
                        }
                    case "-":
                        {
                            result = a - b;
                            break;
                        }
                    case "*":
                        {
                            result = a * b;
                            break;
                        }
                    case "/":
                        {
                            result = a / b;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter proper operater");
                            c++;
                            break;
                        }

                }
                if(c==0)
                Console.WriteLine("The result is " + result);
            }

        }
    }
}
