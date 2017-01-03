using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogExceptionToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10 / {0} = {1}", num, (10/num));
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero.");
                Console.WriteLine(ex.GetType());
                //Console.WriteLine(ex);
                LogException("Exception", "Exception", String.Format((DateTime.Now) + ex.ToString()));
                
            }

        }

        public static void LogException(string strFileName, string strFunctionName, string strContent)
        {
            StreamWriter writer = null;
            StringBuilder strBuilder = null;
            string dir = "C:\\Users\\nicho\\Desktop\\LogFiles\\";
            //string fileName = String.Format("{0:yyyy-MM-dd}_{1}", DateTime.Now, strFileName);
            if(!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string path = Path.Combine(dir, strFileName + ".log");
            strBuilder = new StringBuilder("Log : ");
            strBuilder.Append(strFunctionName + " | ");
            strBuilder.Append(strContent);

            writer = new StreamWriter(path, true);
            writer.Write(strBuilder);
            writer.Close();
        }
    }
}
