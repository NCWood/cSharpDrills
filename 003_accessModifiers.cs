using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessModifiers
{
    class BaseClass
    {
        private int PrivateInt;
        protected int ProtectedInt;
        public int PublicInt;
        internal int InternalInt;
        protected internal int ProtectedInternalInt;
    }

    class DerivedClass : BaseClass
    {
        private void myMethod()
        {
            DerivedClass derObject = new DerivedClass();

            //Accessible outside of BaseClass:
            derObject.ProtectedInt = 98;
            derObject.PublicInt = 76;
            derObject.ProtectedInternalInt = 465;
            
            //Inaccessible outside of BaseClass:
            //derObject.PrivateInt = 54; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseObject = new BaseClass();

            //Accessible outside of BaseClass:
            baseObject.PublicInt = 23;
            baseObject.InternalInt = 10;
            baseObject.ProtectedInternalInt = 123;
            
            //Inaccessible outside of BaseClass:
            //baseObject.PrivateInt = 45;
            //baseObject.ProtectedInt = 67;

            Console.ReadLine();


        }
    }

}
