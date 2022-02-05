using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {

                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")
                {
                    i++;
                    Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
                    Console.WriteLine($"Katseid on alles {3 - i}.");
                }
                else
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
            }
        }
    }
}
