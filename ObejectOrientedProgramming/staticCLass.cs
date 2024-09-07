using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObejectOrientedProgramming
{
    static class StaticCLass
    {
        public static void StaticMethodCall()// cannot declare methods which are not static in static class
        {
            Console.WriteLine("Static");
        }
    }
}
