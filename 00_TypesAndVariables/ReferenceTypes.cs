using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string thisIsDeclaration;
            thisIsDeclaration = "this is initialized";
            string declarationInitialization = "this does both";
            string singleLetter = "a";

            //string manipulation

            string firstName = "jake";
            string lastName = "dombrowski";

            //concatenation
            string concatFullName = firstName + " " + lastName;
            //composite format
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);
            //interpolation
            string interp = $"{firstName} {lastName}";

            Console.WriteLine(concatFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interp);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";
            //array
            string[] stringArray = { "Hello", "what", "when", stringExample };

            string[] threeSpaces = new string[3];

            Console.WriteLine(stringArray[3]);

            //lists
            List<string> listOfStrings = new List<string>();
            List<int> listOfNumbers = new List<int>();

            listOfStrings.Add("hi");
            listOfStrings.Add("two");

            Console.WriteLine(listOfStrings[0]);

            int a = 5;
            int b = a;
            a = 7;
            Console.WriteLine(a + " " + b);
            listOfNumbers.Add(a);
            listOfNumbers.Add(b);
            List<int> secondListOfNumbers = listOfNumbers;
            Console.WriteLine(listOfNumbers[0] + " " + secondListOfNumbers[0]);
            listOfNumbers[0] = 13;
            Console.WriteLine(listOfNumbers[0] +  " " + secondListOfNumbers[0]);
            string firstName = "jake";
            string lastName = firstName;
            lastName = "Dombrowski";
            Console.WriteLine($"{firstName} {lastName}");

            //Queues: first in, first out
            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("i am first");
            firstInFirstOut.Enqueue("i am second");
            firstInFirstOut.Enqueue("i am third");


            //stacks last in first out
            Stack<string> lastInFirstOut = new Stack<string>();
            lastInFirstOut.Push("i am first");
            lastInFirstOut.Push("i am second");


            //dictionaries can be any 2 things
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("bee", "pointy ouch sting");

            string bee = dictionary["bee"];
            Console.WriteLine(bee);
        }
        [TestMethod]
        public void classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next(10, 20);
            Console.WriteLine(randomNumber);
        }

        
    }
}
