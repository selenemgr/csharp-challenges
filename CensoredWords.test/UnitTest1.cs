namespace CensoredWords.test
{
	public class UnitTest1
	{
		[Theory]
		[InlineData("H*ll* W*rld", "eoo")]
		public void ReturnShouldBeTypeString(string value, string value2)
		{
			//Arrange
			CensoredStrings censoredStringsObj = new CensoredStrings();

			//Act
			var result = censoredStringsObj.Uncensor(value, value2);

			//Assert
			Assert.IsType<string>(result);
		}

		[Theory]
		[InlineData("H*ll* W*rld", "eoo")]

		public void SecondParameterShouldBeSameLenghtOfCensoredLetters(string value, string value2)
		{
			//Arrange
			char[] censoredWord = value.ToCharArray();
			char[] vowels = value2.ToCharArray();

			char[] uncensoredChars = Array.FindAll(censoredWord, x => x.Equals('*'));

			//Act
			bool result = vowels.Length == uncensoredChars.Length;

			//Assert
			Assert.True(result);
		}

		[Theory]
		[InlineData("H*ll* W*rld", "eoo")]

		public void ReturnShouldBeUncensoredString(string value, string value2)
		{
			//Arrange
			CensoredStrings censoredStringsObj = new CensoredStrings();

			//Act
			var result = censoredStringsObj.Uncensor(value, value2);

			//Assert
			Assert.Equal("Hello World", result);
		}
	}
}