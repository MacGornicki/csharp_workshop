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

        [Test]
        public void IfmanyConditions()
        {
            var theString =
                "The ththththth th interesting thing about London is that there are always stylish surprises around every corner.";

            string[] result = theString.ToUpper().Split(' ');
            for (int i = 0; i < result.Length; i++)
            {
                if ((result[i].Length > 4) && (result[i].Contains("A")))
                {
                    Console.WriteLine($"{i} Dlugie A");
                }
                else if ((result[i].Contains("B")) || (result[i].Contains("C")))
                {
                    Console.WriteLine($"{i} Dlugie B lub C");
                }
                else if ((result[i].Length == 6) && (!result[i].Contains("E")))
                {
                    Console.WriteLine($"{i} Dlugie bez E");
                }
                else
                {

                    Console.WriteLine($"{i} Nic ciekawego");
                }

            }


        }

        [Test]
        public void StatementSwitch()
        {
            var theString =
                "The ththththth th interesting thing about London is that there are always stylish surprises around every corner.";

            string[] result = theString.ToUpper().Split(' ');
            for (int i = 0; i < result.Length; i++)
            {
                switch (result[i])
                {
                    case "ABOUT":
                        Console.WriteLine($"{i} {result[i]}");
                        break;

                    case "THE":
                        Console.WriteLine("Something");
                        break;

                    case "INTERESTING":                     
                    case "ALWAYS":
                        Console.WriteLine("Harry Potter");
                        break;

                    case "THING":
                        Console.WriteLine("Good movie");
                        break;

                    default:
                        Console.WriteLine("nevermind");
                        break;

                }
            }
        }
    }
}