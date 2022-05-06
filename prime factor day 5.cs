// See https://aka.ms/new-console-template for more information
using System;
class program
{
	public class PrimeFactors
	{
		public static boolean isPrime(int i)
		{
			for (int j = 2; j < i; j++)
			{
				if (i % j == 0)
				{
					return false;
				}
			}
			return true;
		}

		public static void main(String[] args)
		{
			Utility u = new Utility();
			Console.WriteLine("Enter the no. to find PrimeFactors:");
			int n = u.inputInteger();
			Console.WriteLine();
			Console.WriteLine("The prime factors for the " + n + " is:");
			Console.WriteLine();

			for (int i = 2; i <= n; i++)
			{
				if (isPrime(i))
				{
					Console.WriteLine(i + " ");
				}
			}
			Console.WriteLine();
		}
	}
}
