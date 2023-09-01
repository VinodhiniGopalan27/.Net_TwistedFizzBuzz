using System;
using TwistedFizzBuzz;

class Program
{
    static void Main(string[] args)
    {
        int start = 1;
        int end = 100;

        List<string> fizzBuzzOutput = FizzBuzz.GenerateFizzBuzzForSequentialNumbers(start, end);

        foreach (string result in fizzBuzzOutput)
        {
            Console.WriteLine(result);
        }
    }
}
