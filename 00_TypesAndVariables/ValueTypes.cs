using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            //declaring a variable
            bool isDeclared;
            //initializing a variable
            isDeclared = true;
            //declared and initialize use camal case bobJohnIsLow
            bool isDeclaredAndInitialized = true;
        }

        [TestMethod]
        public void Characters()
        {
            //to define a character is single quotes''
            char character = 'a';
            char symbol = '?';
            char number = '1';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            //int short byte long int16 int32 int64
            //2 ^ 8 255 is max 0 is the start
            byte byteExample = 255;
            //can be neg -128 to 127 only 256
            sbyte sbyteExampe = -128;
            //int16 and short are the same, 2^16 
            short shortExample = 32767;
            Int16 anotherShortExample = -32768;
            //2^32
            int intMax = 2147483647;
            Int32 anotherInt = -2147483648;
            uint unSignedInt = 2147483648;
            //2^64
            long longExample = 9223372036854775807;
            Int64 anotherLong = -9223372036854775808;
        }

        [TestMethod]
        public void Decimals()
        {
            //decimal double float
            //floats need to know the type f
            float floatExample = 1.9238575f;
            //do not need the d, assumed default
            double doubleExample = 1.9238575d;
            //most precise, often used for transactions
            decimal decimalExample = 1.923857572376459823742893478239847m;


            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }
        //define a value type for yourself
            enum pastry {donut, cake, cupcake}
        [TestMethod]
        public void Enum()
        {
            pastry myPastry = pastry.cake;
            pastry yourPastry = pastry.donut;
        }

        [TestMethod]
        public void Structs()
        {
            //stucks are the teal that int32 is, int32 is a struct
            Int32 age = 69;
            DateTime today = DateTime.Now;

            DateTime specific = new DateTime(2021, 9, 14);

            DateTime todayTwo = today;

            //var takes its type from right side of assignment operator
            var variable = today;
        }


    }
}
