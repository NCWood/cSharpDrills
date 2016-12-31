using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SerialObject
{
    [Serializable()]

    public class Car : ISerializable
    {
        private string make;
        private string model;
        private int year;
        private Owner owner;

        public Car(string _make, string _model, int _year, Owner _owner)
        {
            this.make = _make;
            this.model = _model;
            this.year = _year;
            this.owner = _owner;
        }

        public Car(SerializationInfo info, StreamingContext ctxt)
        {
            this.make = (string)info.GetValue("Make", typeof(string));
            this.model = (string)info.GetValue("Model", typeof(string));
            this.year = (int)info.GetValue("Year", typeof(int));
            this.owner = (Owner)info.GetValue("Owner", typeof(Owner));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Make", this.make);
            info.AddValue("Model", this.model);
            info.AddValue("Year", this.year);
            info.AddValue("Owner", this.owner);
            
        }
    }

    [Serializable()]

    public class Owner : ISerializable
    {
        private string firstName;
        private string lastName;

        public Owner(string _firstName, string _lastName)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
        }

        public Owner(SerializationInfo info, StreamingContext ctxt)
        {
            this.firstName = (string)info.GetValue("FirstName", typeof(string));
            this.lastName = (string)info.GetValue("LastName", typeof(string));

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FirstName", this.firstName);
            info.AddValue("LastName", this.lastName);
        }
    }

    [Serializable()]

    public class ObjectToSerialize : ISerializable
    {
        private List<Car> cars;

        public List<Car> Cars
        {
            get { return this.cars; }
            set { this.cars = value;  }
        }

        public ObjectToSerialize()
        {

        }

        public ObjectToSerialize(SerializationInfo info, StreamingContext ctxt)
        {
            this.cars = (List<Car>)info.GetValue("Cars", typeof(List<Car>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Cars", this.cars); 
        }
    }

    public class Serializer
    {
        public Serializer()
        {

        }

        public void SerializeObject(string filename, ObjectToSerialize objectToSerialize)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, objectToSerialize);
            stream.Close();
        }

        public ObjectToSerialize DeSerializeObject(string filename)
        {
            ObjectToSerialize objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            objectToSerialize = (ObjectToSerialize)bFormatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car("Bob", "Honda", 2010, new Owner("Bob", "John")));
           

            //save car list to a file
            ObjectToSerialize objectToSerialize = new ObjectToSerialize();
            objectToSerialize.Cars = cars;

            Serializer serializer = new Serializer();
            serializer.SerializeObject("outputFile.txt", objectToSerialize);

            objectToSerialize = serializer.DeSerializeObject("outputFile.txt");
            cars = objectToSerialize.Cars;

            Console.ReadLine();


        }
    }
}
