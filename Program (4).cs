// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;

namespace Lab_2_Activity_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            string pattern = "\\s+";
            string replacment = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacment);
            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement  String: {0}", result);
            Console.ReadKey();
        }
    }
}
