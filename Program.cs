using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
namespace NITIV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Father father = new Father();
            Son son = new Son();
            father=son;

            Daughter daughter = new Daughter();
            father = daughter;

            if (father is Son) { son = father as Son; }
            if (father is Daughter) { }

            LoopingExamples loopingExamples = new LoopingExamples();

            int a=100,b=100;
            int addRes = 0;

            int max;

            int average = loopingExamples.AddAndAverage(a,b, ref addRes);
            int dd = loopingExamples.AddAndAverage(a,b, ref addRes, out max);

            Console.WriteLine(addRes);



            // What is tuple
            //Tuple<string, int, int,bool> myrecord = Tuple.Create("Ram", 100, 1,true);

            //Console.WriteLine(myrecord.Item1);  
            //Console.WriteLine(myrecord.Item2);  
            //Console.WriteLine(myrecord.Item3);

            //Console.WriteLine("Hello, World!");


            //string pattern = @"\d{3}-\d{2}-\d{4}"; // Matches Social Security Numbers (SSN) in the format xxx-xx-xxxx

            //// Input string
            //string input = "My SSN is 123-45-6789";

            //// Create a Regex object
            //Regex regex = new Regex(pattern);

            //// Check if the input string matches the pattern
            //bool isMatch = regex.IsMatch(input);
            //Console.WriteLine($"Is match: {isMatch}");

            //// Find all matches in the input string
            //Match match = regex.Match(input);
            //if (match.Success)
            //{
            //    Console.WriteLine($"Found match: {match.Value}");
            //}


            DateTime dateTime = DateTime.Now;

            Console.WriteLine("Enter value 1 Checked ");

            checked
            {
                int m = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine(m);
            }

            unchecked
            {
                Console.WriteLine("Enter value 2 unchecked");

                int m = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine(m);
            }

            // if 
            int x = 0;

            if (x != 0)
            {
                //less code
            }

            // big coding

            if (true)
            {

            }


            if (true)
            {
                if (true)
                {

                }
                else if (true)
                {

                }
                else
                {

                }


            }


        }


        private void ExLoop()
        {
            while (true)
            {

            }

            do 
            {
                int x = 10; // dont do delarations
            }
            while (true);
            
            for (int i = 0; i < 10; i++)
            {
                // dont change the value of i
                i = 20;
            }

            // Any collection you do foreach

            

        }
        private static Tuple<string, int, int, bool> GetRecord()
        {
            return Tuple.Create("Ram", 100, 1, true);
        }
    }
}
