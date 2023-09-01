using Newtonsoft.Json.Linq;
namespace TwistedFizzBuzz
{
    public class FizzBuzz
    {
        public static List<string> GenerateFizzBuzzForSequentialNumbers(int start, int end)
        {
            List<string> output = new List<string>();

            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    output.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    output.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    output.Add("Buzz");
                }
                else
                {
                    output.Add(i.ToString());
                }

            }
            return output;
        }
        public static List<string> GenerateFizzBuzzForNonSequentialNumbers(List<int> numbers)
        {
            List<string> output = new List<string>();

            foreach (int number in numbers)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    output.Add("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    output.Add("Fizz");
                }
                else if (number % 5 == 0)
                {
                    output.Add("Buzz");
                }
                else
                {
                    output.Add(number.ToString());
                }
            }
            return output;
        }
        public static List<string> GenerateFizzBuzzDynamic(int start,int end, int firstNumber, int secondNumber,int thirdNumber, string firstToken, string secondToken, string thirdToken)
        {
            List<string> output = new List<string>();

            for (int i = start; i <= end; i++)
            {
               
                if (i% firstNumber==0 && i % secondNumber == 0 && i % thirdNumber == 0)
                {
                    output.Add(firstToken + secondToken + thirdToken);
                }
                else if (i % firstNumber == 0 && i % secondNumber == 0)
                {
                    output.Add(firstToken + secondToken);
                }
                else if (i % firstNumber == 0 && i % thirdNumber == 0)
                {
                    output.Add(firstToken + thirdToken);
                }
                else if (i % secondNumber == 0 && i % thirdNumber == 0)
                {
                    output.Add(secondToken + thirdToken);
                }
                else if (i % firstNumber == 0)
                {
                    output.Add(firstToken);
                }
                else if (i % secondNumber == 0)
                {
                    output.Add(secondToken);
                }
                else if (i % thirdNumber == 0)
                {
                    output.Add(thirdToken);
                }
                else
                {
                    output.Add(i.ToString());
                }
            }
            return output;
        }

        public static async Task<List<string>> GenerateFizzBuzzUsingApi(List<int> numbers)
        {
            List<string> output = new List<string>();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://rich-red-cocoon-veil.cyclic.app/");
                    string responseJson = await response.Content.ReadAsStringAsync();
                    int multiple = Convert.ToInt16(JObject.Parse(responseJson)["multiple"]);
                    string token = JObject.Parse(responseJson)["word"].ToString();

                    foreach (int number in numbers)
                    {
                        if (number % multiple==0)
                        {
                            output.Add(token);
                        }
                        else
                        {
                            output.Add(number.ToString());
                        }
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"HTTP r  equest error: {e.Message}");
                }
            }

            return output;
        }

    }
}