using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            /* programm genereerib juhuslikku numbrit 1 kuni 10;
              * kasutaja peab seda numbrit ära arvama;
              * kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
              * kasutajal on 3 katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
              * siis mängu võidab arvuti.
              * programm genereerib juhuslikku numbrit ühte korda
              */

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;
            
            Console.WriteLine("Try to guess the number!");
            while (i < 3)
            {
                Console.Write("Guess the Number: ");
                int playerNumber = Convert.ToInt32(Console.ReadLine());
                if (cpuNumber == playerNumber)
                {
                    Console.WriteLine("Right answer!");
                    break;
                }
                else
                {
                    i++;
                    if (i < 3)
                    {
                        Console.WriteLine("Guess again");
                    }
                }
               
            }
            if (i == 3)
            {
                Console.WriteLine("You lose");
            }
        }

    }
}
