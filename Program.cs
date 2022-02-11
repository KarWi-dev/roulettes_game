using ConsoleRoulette;
using System;

namespace ConsoleRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int TempKonto;
            int GameChoose;
            bool End = false;
            Account Acc = new Account();//name is saved in Acc.Pname and Acc.PKonto is given value=1000
            do
            {
                Console.Clear();
                Console.WriteLine("**Main Menu**\n\nHello " + Acc.PName + "\nYou have " + Acc.PKonto + " Credits\n\n");
                Console.WriteLine("What game do u want to play?\n\nRoulette\t[1]\nBlackjack\t[2]\n4 in a Row \t[3]\n\nExit program\t[4]");
                GameChoose = Convert.ToInt32(Console.ReadLine());

                switch (GameChoose)
                {
                    case 1:
                        TempKonto = Acc.PKonto;
                        RClass R1 = new RClass(TempKonto);
                        Acc.PKonto = TempKonto;
                        break;
                    case 2:
                        TempKonto = Acc.PKonto;
                        BjClass BJ1 = new BjClass(TempKonto);
                        Acc.PKonto = TempKonto;
                        break;
                    case 3:
                        break;
                    case 4:
                        End = true;
                        break;

                    default:
                        Console.WriteLine("Not programmed YET!\nAny Key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            while (End == false);
        }
    }
}