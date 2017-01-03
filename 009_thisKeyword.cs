using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisExample
{
    // The "this" reference variable can be used several times to hold the address of a single object
    class Book
    {
        private string Name, Author;

        public Book(string Name, string Author)
        {
            //A reference to the current instance of the class
            this.Name = Name;
            this.Author = Author;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetAuthor()
        {
            return Author;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           Book cBook = new Book("Walden; or, Life in the Woods", "Henry David Thoreau");
            Book dBook = new Book("Strange Case of Dr. Jekyll and Mr. Hyde", "Robert Louis Stevenson");

            Console.WriteLine("{0} is the author of {1}.", cBook.GetAuthor(), cBook.GetName());
            Console.WriteLine("...and...");
            Console.WriteLine("{0} is the author of {1}.", dBook.GetAuthor(), dBook.GetName());

            Console.ReadLine();
        }
    }
}
