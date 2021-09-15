using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Loops
{
    [TestClass]
    public class packages
    {
        //while for foreach dowhile
        [TestMethod]
        public void While()
        {
            //while loops while (condition boolean has to be true or false) {body of the code will be repeated}
            int counter = 1;

            while (counter != 10)
            {
                Console.WriteLine(counter);
                // counter = counter + 1;
                //counter += 1;
                counter++;
            }

            counter = 1;
            while (true)
            {
                if (counter == 7)
                {
                    Console.WriteLine("goal reached");
                    break;
                }

                counter++;
            }

            Random rng = new Random();
            bool isRunning = true;
            int someCount;

            while (isRunning)
            {
                // 0 (inclusive) 21 (non inclusive) so random number between 0-20
                someCount = rng.Next(0, 21);
                if (someCount == 13 || someCount < 5)
                {
                    // continue loop without progressing code
                    continue;
                }

                Console.WriteLine(someCount);
                if(someCount == 17)
                {
                    //exit condition
                    isRunning = false;
                }
            }

        }
        [TestMethod]
        public void ForLoops()
        {
            int targetNumber = 21;

            for(int i = 0; i < targetNumber; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "jake", "jim", "jill", "bill", "bob" };
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"goodmornin {students[i]}");
            }
        }
        [TestMethod]
        public void ForEachLoops()
        {
            string[] students = { "jake", "jim", "jill", "bill", "bob" };

            foreach(string studuntNmae in students)
            {
                Console.WriteLine(studuntNmae + " is in class today");
            }

            string myName = "Jake Austin Dombrowski";
            foreach (char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void DoWhileLoop()
        {
            int counter = 0;

            do
            {
                Console.WriteLine("hello " + counter);
                counter++;
            }
            while (counter < 5);
        }
    }
}
