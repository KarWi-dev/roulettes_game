using ConsoleRoulette;
using System;

namespace ConsoleRoulette
{
	public class BjClass
	{
		int PlayerPoints;
		int ComPoints;
		int BetAmount;
		int GameCount;
		int RandoCard;
		bool NewCard;
		private int Konto1;
		private bool EndB = false;
		public BjClass(int TempKonto)
		{
			Konto1 = TempKonto;
			do
			{
				Console.Clear();
				Console.WriteLine("Black Jack game NR: " + GameCount);
				Console.WriteLine("You have " + Konto1 + " Credits!\n\n");
				Rando();
				Console.WriteLine(RandoCard);
				Console.ReadKey();
				GameCount++;
				if (Konto1 <= 0)
				{
					Console.WriteLine("Insufficient Credits!!\nGET OUT!!\n");
					EndB = true;
					Console.ReadKey();
				}
				else
				{
					Console.WriteLine("Again? Y/N");
					string x = Console.ReadLine();
					if (x == "N") { x = "n"; }
					if (x == "n") { EndB = true; }
				}
			}
			while (EndB == false);
			Konto1 = TempKonto;
			BetAmount = 0;
		}
		void Rando()
		{
			int[] Cards = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
			Random Rnd = new Random();
			RandoCard = Rnd.Next(Cards.Length);
			RandoCard = Cards[RandoCard];
		}
	}
}
Christian ASP.NET und Webentwicklung. .NET-Desktopentwicklun