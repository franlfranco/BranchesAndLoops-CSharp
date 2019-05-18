using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
        }

        static void Main(string[] args)
        {
            // ExploreIf();

            // While Loop
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            // Do While loop
            counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);

            // For loop
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }

            // Sum of all integers from 1 to 20 divisible by 3.
            int accumulator = 0;
            for(int i = 0; i < 20; i++)
            { 
                if(i % 3 == 0)
                {
                    accumulator += i;
                }
            }

            Console.WriteLine(accumulator);
        }
    }
}
