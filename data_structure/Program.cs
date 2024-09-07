using System;

namespace data_structure
{
    class Program
    {
        static void Main()
        {
            /*Console.WriteLine("String Manupulation...!");
            Console.WriteLine("-----------------------------------------------------------");
            var input = "ABCDEFGHHGFEDCBAA";
            *//*var output = StringManipulation.RemoveDuplicateCharaters(input);
            Console.WriteLine(output);*//*
            var output = StringManipulation.RemoveDuplicateCharaters1(input);
            Console.WriteLine(output);*/

            LinqTest.Test();
            //NumberSystem.Test();
            // CountEachCharacterOfString.CountEachCharacter("NimeshKumarNItinKumarNiteshKumarKN");
            RemoveDuplicate.RemoveDuplicateChar("NimeshKumarNItinKumarNiteshKumarKN");
            Console.ReadLine();
        }
    }
}
