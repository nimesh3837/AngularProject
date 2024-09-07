using System;

namespace ObejectOrientedProgramming
{
    interface IC
    {
        public void Print();
    }
    interface ID
    {
        public void Print();
    }
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("Print :: A");
        }
    }

    class B : A, IC, ID
    {
        //public new void Print()// new keyword uses
        //{
        //    Console.WriteLine("Print :: B");
        //}
        public override void Print()
        {
            Console.WriteLine("Print :: B");
        }
        public void Clear()
        {
            //
        }
    }

    class C : B
    {
        public new void Print()
        {
            Console.WriteLine("Print :: C");
        }
    }

    /// <summary>
    /// This is base class
    /// </summary>
    public class Base
    {
        public Base()
        {
            Console.WriteLine("Print :: Base Constructor");
        }

        public Base(string input)
        {
            Console.WriteLine("Print :: Base Constructor " + input);
        }

        /// <summary>
        /// This method will print the Base class name
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine("Print :: Base");
        }
    }

    /// <summary>
    /// This is derived class
    /// </summary>
    public class Derived : Base
    {
        public Derived() 
        {
            Console.WriteLine("Print :: Derived Constructor");
        }

        public Derived(string input) : base(input)
        {
            base.Print();
            Console.WriteLine("Print :: Derived Constructor " + input);
        }

        /// <summary>
        /// This method will print the Derived class name
        /// </summary>
        public new void Print()
        {
            Console.WriteLine("Print :: Derived");
        }
    }

    /// <summary>
    /// This class used to perform operation related to inheritance.
    /// </summary>
    public class Inheritance
    {
        /// <summary>
        /// This is Test method.
        /// </summary>
        public static void Test()
        {
            A a = new A();
            B b = new B();
            C c = new C();

            A d = new B();//IList a = List(); upcasting downcasting

            a.Print(); // Output -> Print :: A
            b.Print(); // Output -> Print :: B
            b.Clear();
            a = new B();

            a.Print(); // Output -> Print :: B

            d.Print();


            //Base @base = new Base();
            //Derived derived = new Derived();
            //@base.Print(); // Output -> Print :: Base
            //derived.Print(); // Output -> Print :: Derived

            //@base = new Derived();
            //@base.Print(); // Output -> Print :: Base


            //Base @base_param = new Base("parameter base Constuctor");
            //Derived derived_param = new Derived("context");
        }
    }
}
