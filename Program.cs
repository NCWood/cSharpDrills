using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    sealed class BaseClass
    {
        public void NoCanDo()
        {
            Console.WriteLine("This sealed class cannot be inherited by any subclass, but it can be called on its own in the Main method.");
        } 
    }

    /*
    class SubClass : BaseClass
    {
        //This class cannot inherit from the BaseClass since BaseClass is sealed
    }
    */

    class BaseClassTwo
    {
        public string name;

        public void PrintAns()
        {
            Console.WriteLine("What is my method? " + name);
        }
    }

    //This SubClass will inherit is BaseClassTwo is not sealed
    class SubClassTwo : BaseClassTwo
    {
        public void myMethod()
        {
            Console.WriteLine("You certain?");
        }
    }

    class SubClassThree : BaseClassTwo
    {
        public void myOtherMethod()
        {
            Console.WriteLine("Yes.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bassClase = new BaseClass();
            bassClase.NoCanDo();

            SubClassTwo subTwo = new SubClassTwo();
            subTwo.name = " This is my method.";
            subTwo.PrintAns();
            subTwo.myMethod();

            SubClassThree subThree = new SubClassThree();
            subThree.myOtherMethod();

            Console.ReadLine();
        }
    }
}
