namespace FindTheBomb.test
{
	public class UnitTest1
	{
		[Fact]
		public void checkFindTheBombParameterIsString()
		{
			// Arrrange
			FindTheBombObj findtheBomb = new FindTheBombObj();

			// Act
			string input = "hello";
			var result = findtheBomb.FindTheBomb(input);

			// Assert
			Assert.IsType<string>(input);
		}

		[Fact]
		public void checkFindtheBombResultrIsString()
		{
			// Arrrange
			FindTheBombObj findtheBomb = new FindTheBombObj();

			// Act
			string input = "hello";
			var result = findtheBomb.FindTheBomb(input);


			// Assert
			Assert.IsType<string>(result);
		}

		[Fact]
		public void checkFindTheBombResultIsNotBombWhenInputIsNotBomb()
		{
			// Arrrange
			FindTheBombObj findtheBomb = new FindTheBombObj();

			// Act
			string input = "hello";
			var result = findtheBomb.FindTheBomb(input);

			// Assert
			Assert.Equal("There is no bomb, relax.", result);
		}

		[Fact]
		public void checkFindTheBombResultIsBombWhenInputIsBomb()
		{
			// Arrrange
			FindTheBombObj findtheBomb = new FindTheBombObj();

			// Act
			string input = "bomb";
			var result = findtheBomb.FindTheBomb(input);

			// Assert
			Assert.Equal("Duck!!!", result);
		}

		[Theory]
		[InlineData("bomb")]
		[InlineData("BOMB")]
		[InlineData("BoMb")]
		public void checkFindTheBombInputCouldBeUpperCaseOrLowerCaseOrMixed(object value)
		{
			// Arrrange
			FindTheBombObj findtheBomb = new FindTheBombObj();

			// Act
			var result = findtheBomb.FindTheBomb(value.ToString());

			// Assert
			Assert.Equal("Duck!!!", result);
		}
	}
}