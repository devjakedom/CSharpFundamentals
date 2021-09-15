using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void switchCases()
        {
            int input = 1;

            switch(input)
            {
                case 1:
                    Console.WriteLine("hello");
                    break;
                case 2:
                    Console.WriteLine("goodbye");
                    break;
            }
        }
    }
}
