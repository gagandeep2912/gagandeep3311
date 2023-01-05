using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Assignment_04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the equivalent name for type of data you need to create array of");
            string typeName = Console.ReadLine();
            Type type = Type.GetType(typeName, true, true);
            Array myArray = Array.CreateInstance(type, size);

            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value of the type{type.Name}");
                string enteredValue = Console.ReadLine();
                object convertedVlaue = Convert.ChangeType(enteredValue, type);
                myArray.SetValue(convertedVlaue, i);
            }
            Console.WriteLine("All the values are set");
            foreach(object item in myArray)
            {
                Console.WriteLine(item);
            }


         

        }

    }
}
