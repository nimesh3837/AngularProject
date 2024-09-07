using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure
{
    public class RemoveDuplicate
    {
        public static void RemoveDuplicateChar(string input)
        {
            var stringBuilder = new StringBuilder(input[0]);
            var test = input[0];
            var listOutput = new List<char>(input[0]);
            //Console.WriteLine(stringBuilder.ToString());
            foreach (var i in input)
            {
                //Console.WriteLine(i);
                if(listOutput.Contains(i)) 
                {
                    continue;
                }
                else
                {
                    listOutput.Add(i);
                    stringBuilder.Append(i);
                }
            }
            Console.WriteLine(stringBuilder);
        }
    }
}
