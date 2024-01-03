namespace ConvertNumtoMonth
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("Enter a number between 1 and 12: ");
			int month = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(MonthName(month));
		}

		public static string MonthName(int month)
		{
			Dictionary<int, string> months = new Dictionary<int, string>
			{
				{ 1, "January" },
				{ 2, "February" },
				{ 3, "March" },
				{ 4, "April" },
				{ 5, "May" },
				{ 6, "June" },
				{ 7, "July" },
				{ 8, "August" },
				{ 9, "September" },
				{ 10, "October" },
				{ 11, "November" },
				{ 12, "December" }
			};

			return months[month];
		}
	}
}