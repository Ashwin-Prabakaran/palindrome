using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a word to check if it is Palindrome:");
			string inputWord = Console.ReadLine();
			try
			{
				char[] inputWordArray = inputWord.ToCharArray();
				Array.Reverse(inputWordArray);
				string reverse = new string(inputWordArray);

				if (inputWord.Equals(reverse, StringComparison.OrdinalIgnoreCase))
					Console.WriteLine(inputWord + "is a Palindrome");
				else
					Console.WriteLine(inputWord + "is not a Palindrome");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			Console.ReadLine();

		}
	}
}
