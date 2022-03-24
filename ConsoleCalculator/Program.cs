using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi There, Do you want to do math? [Yes/No]");
            string correctAnswer = Console.ReadLine().ToLower();

            if (correctAnswer.Equals("yes") || correctAnswer.Equals("y") || correctAnswer.Equals("no") || correctAnswer.Equals("n"))
            {
                bool YesOrNo = DoYouWannaDoMath(correctAnswer);
                while (YesOrNo == true)
                {
                    Console.WriteLine("What is your First number?");
                    int x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("What is your Second number?");
                    int y = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    int RealAnswer = PlusTwoMethods(x, y);
                    Console.WriteLine($"{x} + {y} = {RealAnswer}");
                    Console.WriteLine();
                    Console.WriteLine(" Do you want to do math? [Yes/No]");
                    string anotherQ = Console.ReadLine().ToLower();
                    if (anotherQ.Equals("yes") || anotherQ.Equals("y"))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Okay, Have a nice day!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Not a correct answer!");
                Console.WriteLine("Good Bye!");
            }



        }

        static int PlusTwoMethods(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        static bool DoYouWannaDoMath(string question)
        {
            string YehOrNey = question;

            if (question.Equals("yes") || question.Equals("y"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }
    //c
    //if (YesOrNo != true)
    //{
    //    Console.WriteLine("Okay, Have a nice day!");
    //}
    //else
    //{
    //    while (YesOrNo == true)
    //    {
    //        Console.WriteLine("What is your First number?");

    //        int x = Int32.Parse(Console.ReadLine());
    //        Console.WriteLine("What is your Second number?");
    //        int y = Int32.Parse(Console.ReadLine());
    //        Console.WriteLine();
    //        int RealAnswer = PlusTwoMethods(x, y);
    //        Console.WriteLine($"{x} + {y} = {RealAnswer}");
    //        Console.WriteLine();
    //        Console.WriteLine("Do you want to do another equation?");

    //        if (Console.ReadLine().ToLower().Equals("no") || Console.ReadLine().ToLower().Equals("no"))
    //        {
    //            continue;
    //        }

    //    }
    //}
}
