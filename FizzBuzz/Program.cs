//Given an integer n, return a string array answer (1-indexed) where:

//answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
//answer[i] == "Fizz" if i is divisible by 3.
//answer[i] == "Buzz" if i is divisible by 5.
//answer[i] == i(as a string) if none of the above conditions are true.


//Example 1:

//Input: n = 3
//Output: ["1","2","Fizz"]
//Example 2:

//Input: n = 5
//Output: ["1","2","Fizz","4","Buzz"]
//Example 3:

//Input: n = 15
//Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]

namespace FizzBuzz
{
	public class FizzBuzzObject
	{
		static void Main(string[] args)
		{
			int input = 15;
			FizzBuzzObject model = new FizzBuzzObject();
			var result = model.FizzBuzz(input);

			Console.WriteLine($"Input: n = {input}");
			Console.WriteLine($"Output: {string.Join(", ", result)}");
		}

		public Stack<string> FizzBuzz(int number)
		{
			Stack<string> result = new Stack<string>();

			for (int i = number; i > 0; i--)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					result.Push("FizzBuzz");
					continue;
				}
				if (i % 3 == 0)
				{
					result.Push("Fizz");
					continue;
				}
				if (i % 5 == 0)
				{
					result.Push("Buzz");
					continue;
				}

				result.Push(Convert.ToString(i));
			}

			return result;
		}
	}
}