using System;
using System.Threading;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Player bot = new Player();
            Player alex = new Player(variants.paper, "Alex");

            Console.Write(bot.whoWins(bot, alex));
        }
    }
}
