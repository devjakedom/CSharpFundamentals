using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            //1 = assigns value assignment operator
            int a = 22;
            int b = 45;

            //addition
            int sum = a + b;

            //subtraction
            int difference = a - b;

            //multiplication
            int multi = a * b;

            //divide
            int divide = a / b;

            // modulos remainder
            int remainder = a % b;

            //overflow
            //casting to a byte 260 is answer but there is 5 left over so it resets to zero and anser is 4, 0 1 2 3 4
            byte number = 200;
            byte othernumber = 60;
            byte thirdnumber = (byte)(number + othernumber);
            Console.WriteLine(thirdnumber);
        }
    }
}
