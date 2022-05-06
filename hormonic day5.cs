// See https://aka.ms/new-console-template for more information 
using  system;
class program
{
	public class Harmonic
	{

		public static void main(String[] args)
		{

			// INITIALIZATION
			double result = 0, num = 0, j;
			int n;
			Utility u = new Utility();

			// INPUT DATA
			Console.WriteLine("enter the harmonic you want to find: ");
			n = u.inputInteger();

			// COMPUTATION
			for (j = 1; j <= n; j++)
			{
				num = num + (1 / j);
				result = num;
			}
			Console.WriteLine("the value of harmonic no. " + n + " is: " + result);

		}

	}
}