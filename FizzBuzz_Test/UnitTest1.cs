using FizzBuzz;

namespace FizzBuzz_Test
{
	public class FizzBuzz_Test
	{
		[Fact]
		public void Parameter_Given_Must_Be_Int()
		{
			// Arrrange
			FizzBuzzObject fizzBuzz = new FizzBuzzObject();

			// Act
			int input = 3;
			var result = fizzBuzz.FizzBuzz(input);

			// Assert
			Assert.IsType<int>(input);
		}

		[Fact]
		public void Return_Should_Be_String_List_Of_Numbers_Before_The_Number_Input()
		{
			// Arrrange
			FizzBuzzObject fizzBuzz = new FizzBuzzObject();

			// Act
			int input = 2;
			var result = fizzBuzz.FizzBuzz(input);

			// Assert
			Assert.Equal(new Stack<string>(new[] { "2", "1" }), result);
		}

		[Fact]
		public void Return_Should_Be_Fizz_When_Input_Is_Divisible_By_3()
		{
			// Arrrange
			FizzBuzzObject fizzBuzz = new FizzBuzzObject();

			// Act
			int input = 3;
			var result = fizzBuzz.FizzBuzz(input);

			// Assert
			Assert.Equal(new Stack<string>(new[] { "Fizz", "2", "1" }), result);
		}

		[Fact]
		public void Return_Should_Be_Buzz_When_Input_Is_Divisible_By_5()
		{
			// Arrrange
			FizzBuzzObject fizzBuzz = new FizzBuzzObject();

			// Act
			int input = 5;
			var result = fizzBuzz.FizzBuzz(input);

			// Assert
			Assert.Equal(new Stack<string>(new[] { "Buzz", "4", "Fizz", "2", "1" }), result);
		}

		[Fact]
		public void Return_Should_Be_FizzBuzz_When_Input_Is_Divisible_By_3_And_5()
		{
			// Arrrange
			FizzBuzzObject fizzBuzz = new FizzBuzzObject();

			// Act
			int input = 15;
			var result = fizzBuzz.FizzBuzz(input);

			// Assert
			Assert.Equal(new Stack<string>(new[] { "FizzBuzz", "14", "13", "Fizz", "11", "Buzz", "Fizz", "8", "7", "Fizz", "Buzz", "4", "Fizz", "2", "1" }), result);
		}
	}
}