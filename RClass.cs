using ConsoleRoulette;
using System;
namespace ConsoleRoulette
{
    internal class RClass
    {
        private string PlayerField;
        private int BetAmount;
        private int GameCount = 1;
        private int WinField;
        private bool Numbers = false;
        private bool EndR;
        private bool Won;
        private int Konto1;
        public RClass(int TempKonto)
        {
            Konto1 = TempKonto;
            do
            {
                Console.Clear();
                Console.WriteLine("Roulette game NR: " + GameCount);
                Console.WriteLine("You have " + Konto1 + " Credits!\n\n");
                Console.WriteLine("On what to bet?\nNumbers [0-36]\neven/odd - red/black\n1st18 - 2nd18\n1st12 - 2nd12 - 3rd12\n1stCol - 2ndCol - 3rdCol");
                PlayerField = Console.ReadLine();
                Console.WriteLine("How much do u want to bet?");
                BetAmount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hit any button to start the game.\n");
                Console.ReadKey();
                Console.Clear();

                if (Konto1 < BetAmount)
                {
                    Console.WriteLine("Max Bet:" + Konto1);
                    Console.ReadKey();
                }
                else
                {
                    Rando();
                    Bet();
                }
            } while (EndR == false);
            TempKonto = Konto1;
        }
        void Rando()
        {
            Random Rnd = new Random();
            WinField = Rnd.Next(0, 36);
        }
        internal void Win()
        {
            Console.WriteLine("You WIN!\nYour number: " + PlayerField + "\nWinning number is: " + WinField + "\nYou won: " + BetAmount + "!\nYour Credits are now at: " + Konto1);
        }
        internal void Loose()
        {
            Console.WriteLine("You LOOSE!\nYour number: " + PlayerField + "\nWinning number is: " + WinField + "\nYou lost: " + BetAmount + "!\nYour Credits are now at: " + Konto1);
        }

        public void Bet()
        {
            try
            {
                int Test = Convert.ToInt32(PlayerField);
                Numbers = true;
            }
            catch { Numbers = false; }

            if (Numbers == true)
            {
                if (Convert.ToInt32(PlayerField) == WinField)
                {
                    Konto1 -= BetAmount;
                    Konto1 += (BetAmount *= 35);
                    Win();
                }
            }
            else
            {
                Won = false;
                switch (PlayerField)
                {
                    case "even":
                        int[] Even = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
                        for (int i = 0; i < Even.Length; i++)
                        {
                            if (Even[i] == Convert.ToInt32(WinField))
                            {
                                Konto1 -= BetAmount;
                                Konto1 += (BetAmount *= 2);
                                Win();
                                Won = true;
                            }
                        }
                        break;
                    case "odd":
                        int[] Odd = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
                        for (int i = 0; i < Odd.Length; i++)
                        {
                            if (Odd[i] == Convert.ToInt32(WinField))
                            {
                                Konto1 -= BetAmount;
                                Konto1 += (BetAmount *= 2);
                                Win();
                                Won = true;
                            }
                        }
                        break;
                    case "red":
                        int[] Red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
                        for (int i = 0; i < Red.Length; i++)
                        {
                            if (Red[i] == Convert.ToInt32(WinField))
                            {
                                Konto1 -= BetAmount;
                                Konto1 += (BetAmount *= 2);
                                Win();
                                Won = true;
                            }
                        }
                        break;
                    case "black":
                        int[] Black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
                        for (int i = 0; i < Black.Length; i++)
                        {
                            if (Black[i] == Convert.ToInt32(WinField))
                            {
                                Konto1 -= BetAmount;
                                Konto1 += (BetAmount *= 2);
                                Win();
                                Won = true;
                            }
                        }
                        break;
                    case "1st12":
                        int[] Ftw = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                        for (int i = 0; i < Ftw.Length; i++)
                        {
                            if (Ftw[i] == Convert.ToInt32(WinField))
                            {
                                Konto1 -= BetAmount;
                                Konto1 += (BetAmount *= 3);
                                Win();
                                Won = true;
                            }
                        }
                        break;
                    case "2nd12":
                        int[] Stw = { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
                        for (int i = 0; i < Stw.Length; i++)
                        {
                            if (Stw[i] == Convert.ToInt32(WinField))
                            {
                                Konto1 -= BetAmount;
                                Konto1 += (BetAmount *= 3);
                                Win();
                                Won = true;
                            }
                        }
                        break;
                    case "3rd12":
                        int[] Ttw = { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
                        for (int i = 0; i < Ttw.Length; i++)
                        {
                            if (Ttw[i] == Convert.ToInt32(WinField))
                            {
                                Konto1 -= BetAmount;
                                Konto1 += (BetAmount *= 3);
                                Win();
                                Won = true;
                            }
                        }
                        break;
                    case "1stCol":
                        int[] Col1 = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
                        for (int i = 0; i < Col1.Length; i++)
                        {
                            if (Col1[i] == Convert.ToInt32(WinField))
                            {
                                Konto1 -= BetAmount;
                                Konto1 += (BetAmount *= 3);
                                Win();
                                Won = true;
                            }
                        }
                        break;
                    case "2ndCol":
                        int[] Col2 = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
                        for (int i = 0; i < Col2.Length; i++)
                        {
                            if (Col2[i] == Convert.ToInt32(WinField))
                            {
                                Konto1 -= BetAmount;
                                Konto1 += (BetAmount *= 3);
                                Win();
                                Won = true;
                            }
                        }
                        break;
                    case "3rdCol":
                        int[] Col3 = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
                        for (int i = 0; i < Col3.Length; i++)
                        {
                            if (Col3[i] == Convert.ToInt32(WinField))
                            {
                                Konto1 -= BetAmount;
                                Konto1 += (BetAmount *= 3);
                                Win();
                                Won = true;
                            }
                        }
                        break;
                    case "1st18":
                        int[] Fet = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
                        for (int i = 0; i < Fet.Length; i++)
                        {
                            if (Fet[i] == Convert.ToInt32(WinField))
                            {
                                Konto1 -= BetAmount;
                                Konto1 += (BetAmount *= 2);
                                Win();
                                Won = true;
                            }
                        }
                        break;
                    case "2nd18":
                        int[] Set = { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
                        for (int i = 0; i < Set.Length; i++)
                        {
                            if (Set[i] == Convert.ToInt32(WinField))
                            {
                                Konto1 -= BetAmount;
                                Konto1 += (BetAmount *= 2);
                                Win();
                                Won = true;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong input!\nU loose ur money!");
                        break;
                }
                if (Won == false)
                {
                    Konto1 -= BetAmount;
                    Loose();
                }
            }//ende Else
            if (Konto1 <= 0)
            {
                Console.WriteLine("Insufficient Credits!!\nGET OUT!!\n");
                EndR = true;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Again? Y/N");
                string x = Console.ReadLine();
                if (x == "N") { x = "n"; }
                if (x == "n") { EndR = true; }
            }
            BetAmount = 0;
            GameCount++;
        }
    }
}