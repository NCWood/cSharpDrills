using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {

        public int quotient;
        

        public void Division(int a, int b)
        {
            try
            {
                quotient = (a / b);
            }
            catch (DivideByZeroException dBz)
            {
                Console.WriteLine("Exception caught: {0}", dBz);
            }
            finally
            {
                Console.WriteLine("Quotient: {0}", quotient);
            }
        }

        static void Main(string[] args)
        {
            Program cProg = new Program();
            cProg.Division(12, 0);
            Console.ReadKey();
        }
    }

}
