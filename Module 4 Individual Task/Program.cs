using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_Individual_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables used in the program
            int pHealth = 100;
            int pHappiness = 100;
            string choice = "";

            // Complete the code below!
            // Add your codes here!

            while (pHealth > 0 && pHappiness > 0)
            {
            // Clears the screen before displaying the text below the instruction!
            Console.Clear();

            // Display the Pet's Stats!
            Console.WriteLine("PET HEALTH   : " + pHealth);
            Console.WriteLine("PET HAPPINESS: " + pHappiness);

            // Display the Pet graphics and Owner's Moves!
            Console.WriteLine("╔════════════════════════════╗ ");
            Console.WriteLine("║   ██████          ██████   ║ ");
            Console.WriteLine("║ ██     ██████████       ██ ║ ");
            Console.WriteLine("║ ██    ██          ██    ██ ║ ");
            Console.WriteLine("║ ██  ████          ████  ██ ║ ");
            Console.WriteLine("║   ██  ██  ██  ██  ██  ██   ║ ");
            Console.WriteLine("║       ██          ██       ║ ");
            Console.WriteLine("║     ██              ██     ║ ");
            Console.WriteLine("║     ██    ██████    ██     ║ ");
            Console.WriteLine("║     ██    ██████    ██     ║ ");
            Console.WriteLine("║     ██              ██     ║ ");
            Console.WriteLine("║       ██    ██    ██       ║ ");
            Console.WriteLine("║         ████  ████         ║ ");
            Console.WriteLine("╠════════════════════════════╣ ");
            Console.WriteLine("║ CHOOSE A MOVE OWNER!       ║ ");
            Console.WriteLine("║                            ║ ");
            Console.WriteLine("║ [A] BATHE PET              ║ ");
            Console.WriteLine("║ [B] PLAY EXTREME FETCH     ║ ");
            Console.WriteLine("║ [C] GO TO THE VET          ║ ");
            Console.WriteLine("║                            ║ ");

            // Get user input

            Console.Write("╚═ENTER CHOICE: ");
            choice = Console.ReadLine();

            // Add your Codes here!

                     
                if (choice == "A" || choice == "a")
                {
                    pHealth = pHealth + 10;
                    pHappiness = pHappiness - 25;
                }

                else if (choice == "B" || choice == "b")
                {
                    pHealth = pHealth - 25;
                    pHappiness = pHappiness + 15;
                }

                else if (choice == "C" || choice == "c")
                {
                    pHealth = pHealth + 20;
                    pHappiness = pHappiness - 40;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                    Console.ReadKey();
                }

            }

            if (pHealth <= 0 || pHappiness <= 0)
            {
                Console.WriteLine("Game Over!");
                Console.ReadKey();
            }

        }
    }
}
