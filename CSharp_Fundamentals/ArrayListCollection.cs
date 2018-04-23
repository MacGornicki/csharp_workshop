using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharp_Fundamentals
{
    [TestFixture]
    public class ArrayListCollection
    {
        [Test]
        public void LoopBasics()
        {
            var theString =
                "The interesting thing about London is that there are always stylish surprises around every corner.";
            string[] result = theString.Split(' ');
            int iterator = 0;
            do
            {

                iterator++;

            }
            while (result[iterator] != "that");
        }

        [Test]
        public void ForLoop()
        {
            var theString =
                "The interesting thing about London is that there are always stylish surprises around every corner.";
            string[] result = theString.Split(' ');
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(i);


            }
        }
        [Test]
        public void IfStatement()
        {
            var theString =
                "The ththththth th interesting thing about London is that there are always stylish surprises around every corner.";
            string[] result = theString.Split(' ');
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == "London")
                {
                    Console.WriteLine("nice city");

                }
                else if (result[i].Contains("th"))
                {

                    if (result[i].Length >= 5)
                    {
                        Console.WriteLine("more than 4 chars");
                        Console.WriteLine("bad city");
                    }
                    else
                    {
                        Console.WriteLine(result[i]);
                    }
                        
                    
                }
                else
                {
                    Console.WriteLine("nothing");
                }
                Console.WriteLine(i);

            }
        }
    }
}
