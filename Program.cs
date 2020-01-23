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

            List<string> myAnimals = new List<string>();
            myAnimals.Add("Tiger");
            myAnimals.Add("Lion");
            myAnimals.Add("Bear");
            myAnimals.Add("Puppy");
            myAnimals.Add("Kitten");

            foreach (string word in myAnimals)
            {
                Console.WriteLine(word);
            }

            List<string> checkBool = new List<string>();
            checkBool.Add("true");
            checkBool.Add("false");
            checkBool.Add("false");
            checkBool.Add("true");
            checkBool.Add("false");

            foreach (string check in checkBool)
            {
                if(check.Equals("true"))
                    Console.WriteLine("Better bring an umbrella");
                else
                    Console.WriteLine("No rain today, enjoy the sun!");
            }

            List<int> numList = new List<int>();

            numList.Add(1);
            numList.Add(23);
            numList.Add(9);
            numList.Add(77);
            numList.Add(922);
            numList.Add(6);
            numList.Add(32);
            numList.Add(63);
            numList.Add(14);
            numList.Add(5);

            CheckList(ref numList);
            CheckListForNumbers(ref numList);
            RemoveNumbersfromList(ref numList);
            CheckListForNumbers(ref numList);
            CheckList(ref numList);

            Console.ReadKey();
        }

        static void CheckList(ref List<int> numList)
        {
            numList.ForEach(j => Console.WriteLine(j));
        }

        static void CheckListForNumbers(ref List<int> numList)
        {
            if (numList.Contains(23))
            {
                Console.WriteLine("23 I am in the list!");
            }

            if (numList.Contains(77))
            {
                Console.WriteLine("77 I am in the list!");
            }

            if (numList.Contains(15))
            {
                Console.WriteLine("15 I am in the list!");
            }

        }

        static void RemoveNumbersfromList(ref List<int> numList)
        {

            numList.Remove(23);
            numList.Remove(922);
            numList.Remove(32);
            numList.Remove(6);
        }
    }
}
