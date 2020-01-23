using System;
using System.Collections.Generic;

namespace sprint3lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myTools = new List<string>();
            myTools.Add("hammer");
            myTools.Add("shovel");
            myTools.Add("wrench");

            if (myTools.Contains("hammer"))
            {
                Console.WriteLine("I have a hammer!");
            }

            foreach (string word in myTools)
            {
                Console.WriteLine(word + "! ");
            }
        }
    }
}
