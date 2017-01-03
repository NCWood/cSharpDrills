using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationOfBLOBject
{
    class Program
    {
        [Serializable]
        public class Example
        {
            public string Name
            { get; set; }

            public Int32 Value
            { get; set; }
        }

        static void Main(string[] args)
        {
            Example example = new Example();
            example.Name = "Theodore Roosevelt";
            example.Value = 100;

            FileStream fileStream = new FileStream(@"C:\\Users\\nicho\\Desktop\\cSharpDrill_Item23\\serial.txt", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, example);
            Console.WriteLine("The object has been serialized!\n");
            fileStream.Close();

            FileStream fileReStream = new FileStream(@"C:\\Users\\nicho\\Desktop\\cSharpDrill_Item23\\serial.txt", FileMode.Open);
            BinaryFormatter reFormatter = new BinaryFormatter();
            Example deserializedExample = (Example)formatter.Deserialize(fileReStream);
            fileReStream.Close();

            Console.WriteLine("The Deserialized Object:");
            Console.WriteLine(String.Format("Name: {0}", deserializedExample.Name));
            Console.WriteLine(String.Format("Value: {0}", deserializedExample.Value.ToString()));

            Console.Read();

        }
    }
}
