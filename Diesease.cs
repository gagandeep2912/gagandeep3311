using System;

namespace SampleFrameworksApp.Assignment
{
    enum Cause { externalfactor,internalfactor};
    class Details
    {
        public string name { get; set; }
        public string severity { get; set; }
        public string dcause { get; set; }
        public string description { get; set; }
        public string symptoms { get; set; }
    }

   
    class AddingDisease
    {
        private Details[] det = null;
        private int size = 0;
        public AddingDisease(int size)
        {
            this.size = size;
            //Console.WriteLine("hi");
            det = new Details[size];
           // Console.WriteLine(size);
            //Console.WriteLine("bye");

        }
        public void AddDisease(Details dts)
        {
            //Console.WriteLine(size);
            for (int i = 0; i < size; i++)
            {
             
                 //Console.WriteLine(  i);
                if (det[i] == null)
                {
                    det[i] = new Details { name = dts.name, severity = dts.severity, dcause = dts.dcause, description = dts.description };
                    Console.WriteLine("Added succesfully" );
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Symptoms(dts);
                    return;
               
                }
                else
                {
                    //Console.WriteLine("hi");
                    throw new Exception("Adding failed");
                }
            
            }

        }
        public static void Symptoms(Details dts)
        {
            Console.WriteLine("Enter the symptoms for "+dts.name);
            Console.WriteLine("Enter the disease name");
           string name= Console.ReadLine();
            Console.WriteLine("Enter the symptom name");
            string symp = Console.ReadLine();
            Console.WriteLine("Enter the description");
            string desc = Console.ReadLine();
        }
        public static void operation()
        {
            Details dts = new Details();
            Console.WriteLine("Enter the name of the disease");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Severity of the disease");
            string severity = Console.ReadLine();
            Console.WriteLine("Enter the cause of the disease");
            Console.WriteLine("ENter of these two"+" "+"externalfactor"+"internalfactor");
            string cause = Console.ReadLine();
            Cause convertedcause = (Cause)Enum.Parse(typeof(Cause), cause);
            dts.dcause =Convert.ToString(convertedcause);

            Console.WriteLine("Enter the Description of the disease");
            string description = Console.ReadLine();
            if (description.Length < 30)
            {
                throw new Exception("Description should excedd 30 lines");
            }
            Details dis = new Details { name = name, severity = severity, dcause = cause, description = description };
            bl.AddDisease(dts);
            



        }
        public static AddingDisease bl = null;
        public static void useful()
        {
            Console.WriteLine("enter the number of diesease to be added");
            int size = Convert.ToInt32(Console.ReadLine());
            bl = new AddingDisease(size);

        }
    }

    class Diesease
    {
            static void Main(string[] args)
            {
                Console.WriteLine("The details of the Diseases");
                AddingDisease.useful();
            AddingDisease.operation();
            }

        }
    }

    

