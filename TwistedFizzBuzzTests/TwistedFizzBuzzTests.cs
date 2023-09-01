using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwistedFizzBuzz;
using System.Collections.Generic;

[TestClass]
public class TwistedFizzBuzzTests
{
    [TestMethod]
    public void TestGenerateFizzBuzzForSequentialNumbers()
    {
        int start = 1;
        int end = 15;

        List<string> expectedOutput = new List<string>
        {
            "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz",
            "11", "Fizz", "13", "14", "FizzBuzz"
        };

        List<string> actualOutput = FizzBuzz.GenerateFizzBuzzForSequentialNumbers(start, end);

        Assert.AreEqual(expectedOutput, actualOutput);
    }
    [TestMethod]
    public void TestGenerateFizzBuzzForNonSequentialNumbers()
    {
        List<int> inputNumbers = new List<int> { 30, 7, 20, 4, 12 };
        List<string> expectedOutput = new List<string>
        {
            "FizzBuzz", "7", "Buzz", "4", "Fizz"
        };

        List<string> actualOutput = FizzBuzz.GenerateFizzBuzzForNonSequentialNumbers(inputNumbers);

        CollectionAssert.AreEqual(expectedOutput, actualOutput);
    }

    [TestMethod]
    public void TestGenerateFizzBuzzDynamic_NormalNumbers()
    {
        int start = 1;
        int end = 20;
        int firstNumber = 3;
        int secondNumber = 5;
        int thirdNumber = 7;
        string firstToken = "Fizz";
        string secondToken = "Buzz";
        string thirdToken = "Auzz";

        List<string> expectedOutput = new List<string>
        {
            "1", "2", "Fizz", "4", "Buzz", "Fizz", "Auzz", "8", "Fizz", "Buzz",
            "11", "Fizz", "13", "Auzz", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz"
        };

        List<string> actualOutput = FizzBuzz.GenerateFizzBuzzDynamic(start, end, firstNumber, secondNumber, thirdNumber, firstToken, secondToken, thirdToken);

        Assert.AreEqual(expectedOutput, actualOutput);
    }
    [TestMethod]
    public async Task TestGenerateFizzBuzzUsingApi()
    {
        List<int> inputNumbers = new List<int> { 3, 6, 9, 12 };
        List<string> expectedOutput = new List<string>
        {
            "Fizz", "Fizz", "Fizz", "Fizz"
        };

        List<string> actualOutput = await FizzBuzz.GenerateFizzBuzzUsingApi(inputNumbers);

        Assert.AreEqual(expectedOutput, actualOutput);
    }


}
