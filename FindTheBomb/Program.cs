//Create a function that finds the word "bomb" in the given string (not case sensitive).
//If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".

//Examples
//Bomb("There is a bomb.") ➞ "Duck!!!"

//Bomb("Hey, did you think there is a bomb?") ➞ "Duck!!!"

//Bomb("This goes boom!!!") ➞ "There is no bomb, relax."
//Notes
//"bomb" may appear in different cases (i.e. uppercase, lowercase, mixed).

namespace FindTheBomb
{
	public class FindTheBombObj
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("Enter a string to check for the word bomb: ");
				string input = Console.ReadLine();

				if (input == "exit")
				{
					break;
				}

				FindTheBombObj findtheBomb = new FindTheBombObj();
				var result = findtheBomb.FindTheBomb(input);
				Console.WriteLine(result);
			}
		}

		public string FindTheBomb(string input)
		{
			if (input.ToLower().Contains("bomb"))
			{
				return "Duck!!!";
			}

			return "There is no bomb, relax.";
		}
	}
}