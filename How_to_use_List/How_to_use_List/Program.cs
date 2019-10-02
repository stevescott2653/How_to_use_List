using System;
using System.Collections.Generic;

namespace How_to_use_List
{
    public class ListExample
    {
        static void Main(string[] args)
        {
            //Create a list of strings
            var names = new List<string>();
            names.Add("John Doe");
            names.Add("Paul");
            names.Add("Bob");
            names.Add("Kevin");

            // Iterate list element using foreach loop
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
