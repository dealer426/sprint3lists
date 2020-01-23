using System;
using System.Collections.Generic;

namespace sprint3lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> giantWords = new List<String>();
            giantWords.Add("fee");
            giantWords.Add("fie");
            giantWords.Add("foe");
            Console.WriteLine(giantWords);
            Console.WriteLine("my list has " + giantWords.Count + " elements");

            giantWords.Add("fum");
            Console.WriteLine(giantWords);
            Console.WriteLine("my list has " + giantWords.Count + " elements");
        }
    }
}
