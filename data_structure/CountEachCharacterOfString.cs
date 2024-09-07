using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure
{
    public class CountEachCharacterOfString
    {
        public static void CountEachCharacter(string input)
        {

            //var input = "NimeshNitinNitesh";
            //var stringBuilderInp = new StringBuilder();

            var dictionaryInp = new Dictionary<char, long>();

            foreach(var i in input)
            {
                if (dictionaryInp.ContainsKey(i))
                {
                    dictionaryInp[i] = dictionaryInp[i] + 1;
                }
                else
                {
                    dictionaryInp.Add(i, 1);
                }
            }
            foreach(var i in dictionaryInp)
            {
                Console.WriteLine(i.Key + " " +i.Value);
            }
        }
    }
}
