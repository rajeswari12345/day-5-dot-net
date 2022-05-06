// See https://aka.ms/new-console-template for more information
using system;
namespace flipcoin
{
	class program
	{
		public class CoinToss
		{
			private enum Coin { Heads, Tails };
			Random randomNum = new Random();
			private int result;
			//private int heads = 0;
			//private int tails = 1;
			Coin coinFlip;

			public void flip()
			{
				result = randomNum.nextInt(2);

				if (result == 0)
				{
					coinFlip = Coin.Heads;
					Console.WriteLine("You flipped Heads!");
				}
				else
				{
					coinFlip = Coin.Tails;
					public class CoinToss
			{
				private enum Coin { Heads, Tails };
				Random randomNum = new Random();
				private int result;
				//private int heads = 0;
				//private int tails = 1;
				Coin coinFlip;

				public void flip()
				{
					Random random = randomNum.nextInt(2);

					if (result == 0)
					{
						coinFlip = Coin.Heads;
						Console.WriteLine("You flipped Heads!");
					}
					else
					{
						coinFlip = Coin.Tails;
					}
				}
			}
		}
	}
}