using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerialBLOBization
{
    class Program
    {
        private const string filename = "serialized.txt";

        static void Main(string[] args)
        {
            Console.WriteLine();
            if (File.Exists(filename))
            {
                Console.WriteLine("Deleting old file");
                File.Delete(filename);
            }

            var greet = "Hello World! This is an example of serialization.";

            FileStream stream = File.Create(filename);
            var formatter = new BinaryFormatter();
            Console.WriteLine("Serializing object...");
            formatter.Serialize(stream, greet);
            stream.Close();

            stream = File.OpenRead(filename);
            Console.WriteLine("Deserializing object...");
            var ReGreet = (string)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine();
            Console.WriteLine("Press Enter key");
            Console.Read();

        }
    }
}
