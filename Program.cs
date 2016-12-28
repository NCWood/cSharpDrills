using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDerivedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Feline cFeline = new createDerivedClass.Feline();
            cFeline.name = "Old Scratch";
            cFeline.legs = 4;
            cFeline.Meow();
            cFeline.PrintBase();
            
            Canine cCanine = new createDerivedClass.Canine();
            cCanine.name = "Spot";
            cCanine.legs = 4;
            cCanine.Bark();
            cCanine.PrintBase();
            

            Human cHuman = new createDerivedClass.Human();
            cHuman.name = "Joe";
            cHuman.legs = 2;
            cHuman.Hello();
            cHuman.PrintBase();
            
            Console.ReadLine();
        }
    }

    class Mammal
    {
        public string name;
        public int legs;

        public void PrintBase()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("No. of legs: " + legs);
        }
    }

    class Feline : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Canine : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }

    class Human : Mammal
    {
        public void Hello()
        {
            Console.WriteLine("Hello!");
        }
    }

}
