using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractVsInterface
{
   abstract class MathOne
    {
        public int add(int a, int b)
        {
            return (a + b);
        }
    }
    
    class MathTwo : MathOne
    {
        public int mult(int a, int b)
        {
            return (a * b);
        }
    }
    
    interface IGreeting
    {
        void Greeting();
    }
    
    class Hello: IGreeting
    {
        public void Greeting()
        {
            Console.WriteLine("Hello!");
            Console.ReadLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            hello.Greeting();
            Console.WriteLine("The Hello class inherited the Greeting method from the IGreeting interface!\n");

            MathTwo mth2 = new MathTwo();
            int result = mth2.add(12, 15);
            Console.WriteLine("Your result: {0}\n", result);
            Console.WriteLine("The MathTwo class inherited the add() method from the MathOne class, even though it only contains the mult() method when used alone!\n");
            Console.ReadLine();
        }
    }
}
