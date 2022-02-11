using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRoulette
{
    class Account
    {
        public string PName { get; }
        public int PKonto { get; set; }

        public Account()
        {
            Console.Clear();
            Console.WriteLine("PLease Enter your Name:");
            PName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Name Saved.\nYou get 1000 Credits to start with!\n\nPress Key to Continue");
            Console.ReadLine();
            PKonto = 1000;
        }
    }
}