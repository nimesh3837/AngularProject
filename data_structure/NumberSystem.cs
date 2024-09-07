using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure
{
    public class NumberSystem
    {
        /// <summary>
        /// This test method to call other utility methods.
        /// </summary>
        public static void Test()
        {
            var arr = new long[5];
            arr[0] = 2;
            arr[1] = 3;
            arr[2] = 4;
            arr[3] = 6;
            arr[4] = 9;
            var arr1 = new long[5] { 2, 4, 5, 7, 8 };
            Console.WriteLine(printNumberWithHashAndDash(arr1));
        }

        /// <summary>
        /// This method used to print list of number using #(if subsequence elements are even) or - (if subsequence elements are odd). 
        /// </summary>
        /// <param name="list">List of elements.</param>
        /// <returns>Output with # and -</returns>
        private static string printNumberWithHashAndDash(long[] list)
        {
            var output = new StringBuilder();

            // Return if list is null
            if (list == null) return null;


            for (int i = 0; i < list.Length; i++)
            {
                if (i == list.Length - 1)
                {
                    output.Append(list[i].ToString());
                    break;
                }

                if (list[i] % 2 == 0 && list[i + 1] % 2 == 0)
                {
                    output.Append(list[i] + "#");
                }
                else if (list[i] % 2 == 1 && list[i + 1] % 2 == 1)
                {
                    output.Append(list[i] + "-");
                }
                else
                {
                    output.Append(list[i].ToString());
                }
            }
            return output.ToString();
        }
    }
}
