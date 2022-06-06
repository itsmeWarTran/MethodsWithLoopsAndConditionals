using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            thousand();
            byThree();
            Console.WriteLine(isEqual(5, 5));
            Console.WriteLine(evenOrOdd(33));
            Console.WriteLine(posOrNeg(32));

            Console.WriteLine("Enter your age to see if you can vote or not");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(canVote(age));
        }
        public static void thousand()//thousand
        { 
            for(int x=1000; x>=-1000; x--)
            {
                Console.WriteLine(x);
            }
        }

        public static void byThree()// multiply 3
        {
            for(int x=3; x<=1000; x+=3)
            {
                Console.WriteLine(x);
            }
        }

        public static Boolean isEqual(int num1, int num2) //is Equal
        {
            if(num1 == num2)
            {
                return true;
            }
            return false;
        }

        public static string evenOrOdd(int num) //evenOrOdd
        {
            if (num % 2 == 0)
            {
                return "even";
            }
            return "odd";
        }

        public static string posOrNeg(int num) //posOrNeg
        {
            if (num < 0)
            {
                return "Negative";
            }
            return "Positive";
        }

        public static Boolean canVote(int age)//canVote
        {
            if(age >= 18)
            {
                return true;
            }
            return false;
        }
    }
}
