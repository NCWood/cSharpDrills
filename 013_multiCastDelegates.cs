using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void Greetings(string s);

namespace multiCastDelegate
{
    class Program
    {

        static void Hello(string s)
        {
            Console.WriteLine(" Hello, {0}", s);
        }

        static void Goodbye(string s)
        {
            Console.WriteLine(" Goodbye, {0}", s);
        }

        static void Main(string[] args)
        {
            Greetings hiGreet, byeGreet, comboGreet, comboLessHiGreet;

            hiGreet = Hello;
            byeGreet = Goodbye;
            comboGreet = hiGreet + byeGreet;
            comboLessHiGreet = comboGreet - hiGreet;

            Console.WriteLine("Invoking delegate hiGreet:");
            hiGreet("I");
            Console.WriteLine("Invoking delegate byeGreet:");
            byeGreet("II");
            Console.WriteLine("Invoking delegate comboGreet:");
            comboGreet("III");
            Console.WriteLine("Invoking delegate comboLessHiGreet:");
            comboLessHiGreet("IV");

        }
    }
}
