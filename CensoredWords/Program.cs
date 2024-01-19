namespace CensoredWords
{
	public class CensoredStrings
	{
		public static void Main(string[] args)
		{

		}

		public string Uncensor(string word1, string word2)
		{
			char[] censoredWord = word1.ToCharArray();

			int vowelIndex = 0;

			foreach (char letter in word1)
			{
				if (letter == '*')
				{
					int index = Array.IndexOf(censoredWord, letter);
					censoredWord[index] = word2[vowelIndex];
					vowelIndex++;
				}
			}

			string uncensoredWord = new string(censoredWord);

			return uncensoredWord;
		}
	}
}