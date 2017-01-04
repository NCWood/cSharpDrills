using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int Numbers(int n);

namespace Delegating
{
    class Program
    {
        static int num = 50;

        public static int AddNum(int x)
        {
            num += x;
            return num;
        }

        public static int MultNum(int y)
        {
            num *= y;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            Numbers numbOne = new Numbers(AddNum);
            Numbers numbTwo = new Numbers(MultNum);

            numbOne(15);
            Console.WriteLine("The value of num: {0}", getNum());
            numbTwo(10);
            Console.WriteLine("The value of num: {0}", getNum());

            Console.ReadLine();

        }
    }
}
