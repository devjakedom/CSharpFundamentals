using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Conditionals
{

    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool isHungry = true;
            if (isHungry)
            {
                Console.WriteLine("go eat bro");
            }

            int hoursSleeping = 1;
            if (hoursSleeping > 12) 
            { 
            Console.WriteLine("how do you sleep so much?");
        }
        }

        [TestMethod]
        public void ifElseStatement()
        {
            bool homeworkDone = false;
            if(homeworkDone)
            {
                Console.WriteLine("go watch netflix");
            }
            else
            {
                Console.WriteLine("get back to work");

            }

            int age = 15;
            if (age < 10)
            {
                Console.WriteLine("child");
            }
            else (age > 14)
                    {
                Console.WriteLine("older"); 
            
            }
        }
    }
}
