using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObejectOrientedProgramming
{
    public class TypesOfConstructor
    {
        //public TypesOfConstructor() { } // default or public contructor

        public TypesOfConstructor(int type) { } // parameterized constructor

        private TypesOfConstructor() { } // private constructor
         //One use of a private constructor is when we have only static members.
         //It provides an implementation of a singleton class pattern
         //Once we provide a constructor that is either private or public or any, the compiler will not add the parameter-less public constructor to the class.

        //static TypesOfConstructor() { } // no parameter in static 
        //A static constructor does not take access modifiers or have parameters.
        //A static constructor is called automatically to initialize the class before the first instance is created or any static members are referenced.
        //A static constructor cannot be called directly.
        //The user has no control over when the static constructor is executed in the program.
        //A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.
        
        public static void method1() // have to create static method as constructor is private togive singleton 
        {
            Console.WriteLine("test");
        }
    }

    public class testConstructor
    {
        public static void Main()
        {
            //var publicConstructor = new TypesOfConstructor();

            var parameterizedCOnstrictot = new TypesOfConstructor(1234);

            //var privateConstructr = new TypesOfConstructor();// we cannot instantiated for private or static constructor

            //var staticConstructor = new TypesOfConstructor();// we cannot instantiated for private or static constructor

            TypesOfConstructor.method1();



        }
    }
}
