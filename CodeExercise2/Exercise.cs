using System;
using System.Text;

/* This the original code */
namespace Coding.Exercise
{
    public class Exercise
    {
        // TODO: fix this method - fix bugs, make more efficient, and return correct result
        public static string ReplaceDigits(string sentence)
        {
            StringBuilder builder = new StringBuilder(sentence);

            string[] words = {"zero ","one ","two ","three ","four ","five ","six ", 
           "seven ","eight ","nine " };
            for (int i = 0; i < words.Length; i++)
            {
                builder.Replace(i.ToString(), words[i]);
            }
            builder.Replace("  ", " ");

            return builder.ToString().Trim();
        }
    }
}
