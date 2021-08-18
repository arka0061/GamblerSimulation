using System;

namespace GambleSimulation
{
    class Program
    {
        public const int STAKE = 100;
        public const int BET = 1;

        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Welcome To Gambler Simulatiion!");
            program.CheckBet();
        }
        public void CheckBet()
        {
            int gamble;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == 0)
            {
                gamble = STAKE + BET;
                Console.WriteLine("Profit " + gamble);
            }
            else
            {
                gamble = STAKE - BET;
                Console.WriteLine("Loss " + gamble);
            }

        }
    }
}
