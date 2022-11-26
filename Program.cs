// See https://aka.ms/new-console-template for more information
using System;

namespace csproj
{
    class Myproj{
        static void Main(string[] args){

            Console.WriteLine("Game of Dice \nThis game is of THREE rounds\n"+
            "Both  have to role a dice whose number is greater will win \n"+
            "In the end the one who scores more will win\n"+
            " Press any key Start the Game");

            Console.ReadKey();
            
            int youRandom,enemyRandom;
            int youPoints=0,enemyPoints=0;
            
            Random random = new Random();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Round "+ i);
                Console.WriteLine(" Press Enter key to Roll a Dice");

                Console.ReadKey();

                Console.Write("Rolling... ");
                System.Threading.Thread.Sleep(1000);
                youRandom = random.Next(1,7);
                Console.WriteLine(""+ youRandom);
                System.Threading.Thread.Sleep(500);

                Console.Write("Enemy Rolling... ");
                System.Threading.Thread.Sleep(1000);

                enemyRandom = random.Next(1,7);
                Console.WriteLine(""+ enemyRandom+"\n");

                if(youRandom>enemyRandom){
                    youPoints++;
                    Console.WriteLine("You wins this round");
                }else if(enemyRandom>youRandom){
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round");
                }else{
                    Console.WriteLine("This Round is a Tie");
                }

                System.Threading.Thread.Sleep(500);

                Console.WriteLine("Current Score: You- "+youPoints+" Enemy- "+enemyPoints);
                Console.WriteLine();

            }
        if(youPoints>enemyPoints){
            Console.WriteLine("You Win...");
        }else if(enemyPoints>youPoints){
            Console.WriteLine("Enemy Wins...");
        }else{
            Console.WriteLine("Its a Draw!...");
        }

        }
    }
}

