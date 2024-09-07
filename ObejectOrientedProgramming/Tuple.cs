using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObejectOrientedProgramming
{
    public class Tuple
    {
        static Tuple<string, int> getMark()
        {
            return new Tuple<string, int>("Maths", 91);
        }

        static ICollection<Tuple<string, int>> getMarks()
        {
            return new List<Tuple<string, int>>() { new Tuple<string, int>("Maths", 91),
            new Tuple<string, int>("English", 60),
            new Tuple<string, int>("Science", 55)};
        }

        public static void Test()
        {
            var tuple = getMark();
            Console.WriteLine(tuple.Item1 + " - " + tuple.Item2);
            var tuples = getMarks();
            tuples.ToList().ForEach(t => Console.WriteLine(t.Item1 + " - " + t.Item2));
            new Tuple<int, int, int, int, int, int, int, int>(1,1,1,1,1,1,1,1);
        }
    }
}
