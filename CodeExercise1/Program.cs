using System;
using Coding.Exercise;

namespace CodeExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Dictionary<char, int> results = 
                Exercise.GetCharacterCount("John Doe");

            foreach (char key in results.Keys){
                Console.WriteLine("'" + key + "': " + results[key]);
            }
        }
    }
}
