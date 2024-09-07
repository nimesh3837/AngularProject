using System;

namespace ObejectOrientedProgramming
{
    abstract class Shape
    {
        public void Print()
        {
            Console.WriteLine("Shape :: Print"); // we cannot create an instance of abstractclass we canonly inherit it
        }

        public abstract void Draw();
    }


    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle :: Print");
        }
    }

    internal class Abstration
    {
        public static void Test()
        {
            Shape circle = new Circle();
            circle.Draw();
            circle.Print();
        }
    }
}
