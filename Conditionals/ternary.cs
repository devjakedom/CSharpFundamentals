using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Conditionals
{
    [TestClass]
    public class ternary
    {
        [TestMethod]
        public void ternaries()
        {
            //condition/boolean ? ifTrueDoThis : ifFalseDoThis;
            int numberOfDucks = 10;
            string answer = (numberOfDucks > 8) ? "that is too many" : "that is too few";
        }
    }
}
