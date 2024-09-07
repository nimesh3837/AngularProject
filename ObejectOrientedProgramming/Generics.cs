using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObejectOrientedProgramming
{
    internal class Generics
    {
        public static void Test()
        {
            var list = new MyList<string>();
            list.Add("First"); 
            list.Add("Second");

            Console.WriteLine("Count :: "+list.Count);
            Console.WriteLine("Element :: "+list.Get(0));
            Console.WriteLine("Element :: "+list[1]);


        }
    }
}
