using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overLoad_V_overRide
{
    class ovrRideBaseClass
    {
        public virtual void greeting()
        {
            Console.WriteLine("The Base Class says hello!");
        }
    }

    class ovrRideSubClass : ovrRideBaseClass
    {
        public override void greeting()
        {
            //base.greeting();
            Console.WriteLine("The Sub Class says hello!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //------overloading-----

            addOvrLoad(2, 3);
            addOvrLoad(2, 3, 4);
            addOvrLoad(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

            //------overriding--------

            ovrRideBaseClass object1 = new ovrRideSubClass();
            //ovrRideBaseClass object1 = new ovrRideBaseClass();
            object1.greeting();


            //----Print both overload and override methods--------
            Console.ReadLine();

        }

        public static void addOvrLoad(int a, int b)
        {
            Console.WriteLine("The sum of the method with two arguments is: " + (a + b));
        }

        public static void addOvrLoad(int a, int b, int c)
        {
            Console.WriteLine("The sum of the method with three arguments is: " + (a + b + c));
        }

        public static void addOvrLoad(int[] array)
        {
            int sum = 0;
            foreach (int a in array)
            {
                sum += a;
            }
            Console.WriteLine("The sum of the method with an array as an argument is: " + sum);
        }

        
    }
}
