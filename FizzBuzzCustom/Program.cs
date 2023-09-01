using System;
using TwistedFizzBuzz;

class Program
{
    static void Main(string[] args)
    {
        int start = -20;
        int end = 127;
        int firstNumber = 5;
        int secondNumber = 9;
        int thirdNumber = 27;
        string firstToken = "Fizz";
        string secondToken = "Buzz";
        string thirdToken = "Bar";
        List<string> fizzBuzzOutput = FizzBuzz.GenerateFizzBuzzDynamic(start, end, firstNumber, secondNumber,
                                        thirdNumber, firstToken, secondToken, thirdToken);

        foreach (string result in fizzBuzzOutput)
        {
            Console.WriteLine(result);
        }
    }
}
