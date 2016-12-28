using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface InterfaceOne
    {
        void SayHello();
    }

    interface InterfaceTwo
    {
        void SayGoodbye();
    }

    class Salutations : InterfaceOne, InterfaceTwo
    {
        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye.");
            //throw new NotImplementedException();
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!");
            //throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {  

            Salutations cSalut = new Salutations();
            cSalut.SayHello();
            cSalut.SayGoodbye();

            Console.ReadLine();
        }
    }
}
