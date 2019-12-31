using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        // TODO: fix this method - remove boxing & unboxing, and return correct result
        public static Dictionary<char, int> GetCharacterCount(string name)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            name = name.ToLower();

            char key;
            for (int i = 0; i < name.Length; i++)
            {   
                key = name[i];
                if (key == ' ') {
                    continue;
                }

                if (!result.ContainsKey(key)) {
                    result.Add(key, 0);
                }

                result[key] += 1;    
            }

            return result;
        }
    }
}
