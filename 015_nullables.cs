using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;

            if (num.HasValue)
            {
                Console.WriteLine("num = " + num.Value);
            }
            else
            {
                Console.WriteLine("num = Null");
            }

            int y = num.GetValueOrDefault();

            try
            {
                y = num.Value;
            }
            catch (System.InvalidOperationException except)
            {
                Console.WriteLine(except.Message);
            }

            int? x = 15;
            if (x.HasValue)
            {
                Console.WriteLine("The value of x is: {0}", x.Value);
            }
            else
            {
                Console.WriteLine("The value is undefined.");
            }

            Console.ReadLine();
        }
    }
}
