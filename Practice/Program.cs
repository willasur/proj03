using System;


namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        { //primitive data types, simplest form
            string neWord = "Is this the real life \n";
            string neWordB = "Is this just fantasy? \n";
            var neWordC = "Caught in a landlslide";
            var firstChar = 'X';
            int bigInt = int.MaxValue;
            uint postInt = uint.MaxValue;
            short shortNum = 5;
            float floatNum = 1.456f;
            var pi = 3.14f;//specifies a float
            var piB = 3.14d; //double, implicit
            double pi2 = 3.14d;//double
            bool truth = true; //boolean explicit
            var fact = false; //boolean implicit

            //everything is an object

            int.Parse("234");//convert string "234" to int 234
            //example of static method, some are available only after instantiation
            string test = "abcdef";
            string test2 = test.ToUpper();
            string test3 = "ABCDEF";
            string test4 = test3.ToLower();
            Console.WriteLine($"{test2}\n{test4}");

            var trimExample = "  No Space Left  ";
            var trimExample2 = trimExample.Trim();
            Console.WriteLine(trimExample2); //will eliminate whitespace

            var subStrexample = "This is ground control to Major Tom";//methods on string
            var subStrexample2 = subStrexample.Substring(0, 9);
            Console.WriteLine(subStrexample2);
            //property on string
            var propertyExample = subStrexample.Length; //no parenthesis to invoke, unlike method
            Console.WriteLine(propertyExample);

            var challenge = "im a creep, im a weirdo, what the hell am i doing here i dont belong here";
            var challengeAns = challenge.Substring(challenge.Length - 19).ToUpper();
            Console.WriteLine(challengeAns);

            Console.WriteLine($" {firstChar} {neWord} {neWordB} {neWordC}");
            Console.WriteLine($"{bigInt}{shortNum}"); //take note how interpolation worked on bigInt
            Console.WriteLine(postInt);
            Console.WriteLine($"{pi} {pi2} {floatNum} {piB}");
            Console.WriteLine($"is it {truth} or {fact}?");


            //stringbuilder example
            var strBuildex = new System.Text.StringBuilder();
            strBuildex.Append("Open your eyes \n");
            strBuildex.Append("Look up to the skies \n");
            strBuildex.Append("And See \n");
            var strbB = strBuildex.ToString();
            Console.WriteLine(strbB);
            //use appendlines no need for \n
            var strBuildEx2 = new System.Text.StringBuilder();
            strBuildEx2.AppendLine("Any way the wind blows");
            strBuildEx2.AppendLine("Doesn't really matter to me");
            strBuildEx2.AppendLine("to me ...");
            var strbC = strBuildEx2.ToString();
            Console.WriteLine($"{strbB}\n{strbC}");

            //string format - substitution
            var city = "Seattle";
            var temperature = 89.5f;
            var currenTime = DateTime.Now;
            var welcomeNote = string.Format("Welcome to {0}.\nIt is {1:t} PST and current tempeature is {2} F", city, currenTime, temperature);
            Console.WriteLine(welcomeNote);

            //parse, try parse example

            int parsExample = int.Parse("123");
            Console.WriteLine(parsExample);
            int endResult;
            int.TryParse("1234", out endResult);//bool will result to false (0) with a comma
            Console.WriteLine(endResult);

            //math operations
            //constants - more optimized, compiler treats as hard code

            var math1 = Math.Abs(-65);//absolute value
            var math2 = Math.Pow(3, 3);//3 raised to 3
            var math3 = Math.Round(4.5722);//round to nearest
            var math4 = Math.Ceiling(9.1);//round up

            Console.WriteLine($"{math1}\n{math2}\n{ math3}\n{math4}");

            Console.WriteLine(DateTime.Now);












        }
    }
}


    


    
    
