using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReference
{
    class Program
    {
        //A class is a reference type
        class Addition
        { 
            //ints a and b are value types that
            public void addInt()
            {
                int a;
                int b;

                Console.Write("Enter your first integer to add: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your second integer to add: ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Sum of {0} and {1} is: " + (a + b), a,b);
                Console.WriteLine("\nThe integers {0} and {1} are examples of VALUE TYPES. \nThe class which contains the value types and the method which adds these integers is a REFERENCE TYPE.", a,b);
            }
        }

        static void Main(string[] args)
        {
            Addition cAdd = new Addition();
            
            //The integers a and b are assigned values of 15 and 162, respectively, and are each value types
            cAdd.addInt();
            
            Console.ReadLine();

        }
    }
}
