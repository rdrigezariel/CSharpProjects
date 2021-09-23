using System;
using System.Text;

namespace StringAssignment
{
    static class Program
    {
        static void Main()
        {
            // #1 Concat three strings
            string stringOne = "Hello";
            string stringTwo = "There";
            string stringThree = "World";
            // Concatenated string
            string concatString = stringOne + stringTwo + stringThree;

            Console.WriteLine(concatString);

            // #2 Covert concatString to uppercase
            string upperConcatString = concatString.ToUpper();

            Console.WriteLine(upperConcatString);

            // #3 Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Ariel.");
            sb.Append(" I am 29 years old.");
            Console.WriteLine(sb);
        }
    }
}
