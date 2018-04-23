using System;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;

namespace CSharp_Fundamentals
{
    [TestFixture]
    public class StringsAndItsOperations
    {
        /// <summary>
        /// String is diffrent then previues types we talk about
        /// values of string we are passing in quotation marks
        /// 
        /// Create new string with your name and then add them together
        /// </summary>
        [Test]
        public void Bascis_Of_Strings()
        {
            string Example = "Add";
            string MyString = "Add";
            string Result = Example + MyString;
            Console.WriteLine(Result);

            Assert.True(Example == MyString);


        }

        /// <summary>
        ///  string is  first Reference Type you see (We will talk more about them later)
        ///  which means he doesn't have to have value.
        ///  use string.Empty;
        ///  create new strings itsEmpty and make it empty
        /// </summary>
        [Test]
        public void String_Initialization()    
        {
            string itsEmpty = string.Empty;
            Assert.That(itsEmpty, Is.Not.Null);
        }

        /// <summary>
        /// + is not best way of adding string
        ///  use string.Concat();
        ///  put sentence together
        /// </summary>
        [Test]
        public void Adding_String()
        {
            string first = "pancakes.";
            string second = "I like";
            string restult = string.Concat(second," ",first);

            Assert.AreEqual(restult, "I like pancakes.");
        }

        /// <summary>
        /// There is few more ways of cosntructing strings for example if you need add values of other variables inside you can do
        /// https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.7.1#Starting
        /// create string with both x and y insed
        /// </summary>
        [Test]
        public void String_Format()
        {
            int x = 500;
            int y = 453;
            string result;
            result = String.Format($"The result is {x} {y}");
            StringAssert.Contains(x.ToString(),result);
            StringAssert.Contains(y.ToString(),result);
        }

        /// <summary>
        /// From theString return word "thing".
        /// hint use Substring() method 
        /// </summary>
        [Test]
        public void Substrings()
        {
            var theString =
                "The interesting thing about London is that there are always stylish surprises around every corner.";
            string result = theString.Substring(16,5);


            Assert.AreEqual("thing",result);
        }

        [Test]
        public void Split()
        {
            var theString =
                "The interesting thing about London is that there are always stylish surprises around every corner.";
            string[] result = theString.Split(' ');


            Assert.AreEqual("thing", result[2]);
        }
    }
}