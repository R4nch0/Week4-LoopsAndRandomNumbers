using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* programm küsib kasutajal sisestada PIN-koodi;
             * programm võrdleb sisestatud PIN-koodi arvuga 1234;
             * kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
             * kui siesestatud PIN-kood on miadgi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
             * kasutajal on kolm katset.  i < 3  >
             * */

            int i = 0;  //i- iteration

            while (i < 3) //while-loop
            {
                Console.WriteLine("Siesesta PIN: ");
                int userPIN = Convert.ToInt32(Console.ReadLine());              
                
                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale Pin. {3 - i} katset on jäänud.");
                }
             
            }

                                
            Console.WriteLine("Kena päeva!");

        }
    }
}
