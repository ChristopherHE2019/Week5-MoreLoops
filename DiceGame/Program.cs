using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int cpuScore = 0;
            int userScore = 0;

            for(int i = 0; i < 3; i++)
            {
                int cpuRandom = rnd.Next(1, 7);

                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viaskas {userRandom}.");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja võitis raundi.");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti võitis raundi.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }
            if (cpuScore < userScore)
            {
                Console.WriteLine($"Kasutaja võitis mängu {userScore} punktiga.");
            }
            else if (cpuScore > userScore)
            {
                Console.WriteLine($"Arvuti on mängu võitnud {cpuScore} punktiga.");
            }
            else
            {
                Console.WriteLine("Mäng lõppes viigiga.");
            }
        }
    }
}
