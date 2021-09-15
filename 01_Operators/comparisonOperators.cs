using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Operators
{
    [TestClass]
    public class comparison
    {
        [TestMethod]
        public void comparisonOperators()
        {
            int year = 2021;
            string name = "jake";

            // equal ==
            bool equal = year == 2021;
            bool isThisBob = name == "bob";
            Console.WriteLine(equal);
            Console.WriteLine(isThisBob);

            //inequality != (bang operator)
            bool notEqual = year != 2021;
            bool isNotBob = name != "bob";
            Console.WriteLine(notEqual);
            Console.WriteLine(isNotBob);

            bool trueValue = true;
            bool falseValue = false;

            //or

            bool tort = trueValue || trueValue; //true
            bool torf = trueValue || falseValue; //true
            bool fort = falseValue || trueValue; //true
            bool forf = falseValue || falseValue; // false

            //and &&
            bool tandt = trueValue && trueValue; //true
            bool tandf = trueValue && falseValue; //false
            bool fandt = falseValue && trueValue; //false
            bool fandf = falseValue && falseValue; //false



            {

            }
        }
    }
}
