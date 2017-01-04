using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> result = from value in Enumerable.Range(0, 10) select value;


            foreach (int value in result)
            {
                Console.WriteLine(value);
            }

            double average = result.Average();

            List<int> list = result.ToList();
            int[] array = result.ToArray();
        }
       
    }
}
