
using System.Text;

namespace data_structure
{
    /// <summary>
    /// This class used to perform operations on string.
    /// </summary>
    public class StringManipulation
    {
        /// <summary>
        /// This method used to remove duplicate charaters
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>distict charaters</returns>
        public static string RemoveDuplicateCharaters(string input)
        {
            var temp = input[0];
            var output = new StringBuilder();
            output.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (!input[i].Equals(temp))
                {
                    output.Append(input[i]);
                    temp = input[i];
                }
            }
            return output.ToString();
        }

        public static string RemoveDuplicateCharaters1(string input)
        {
            var temp = input[0];
            var output = new StringBuilder();
            var status = false;
            var duplicateOutput = false;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i].Equals(temp))
                {
                    status = true;
                }
                else
                {
                    if (!status)
                    {
                        if (output.Length > 0 && output[^1].Equals(temp))
                        {
                            duplicateOutput = true;
                        }
                        else
                        {
                            if (duplicateOutput)
                            {
                                var index = output.ToString().IndexOf(output[^1]);
                                output.Remove(index, output.Length - index);
                                duplicateOutput = false;
                                if (output.Length > 0 && output[^1].Equals(temp))
                                {
                                    duplicateOutput = true;
                                }
                            }
                        }
                        output.Append(temp);
                    }
                    status = false;
                    temp = input[i];
                }
            }

            if (duplicateOutput)
            {
                var index = output.ToString().IndexOf(output[^1]);
                output.Remove(index, output.Length - index);
                duplicateOutput = false;
            }

            if (!status)
            {
                if (output[^1].Equals(input[^1]))
                {
                    var index = output.ToString().IndexOf(output[^1]);
                    output.Remove(index, output.Length - index);
                }
                else
                {
                    output.Append(input[^1]);
                }
            }

            return output.ToString();
        }

    }
}
