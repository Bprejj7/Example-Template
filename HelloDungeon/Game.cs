using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        
        public string GetInput(string prompt, string option1, string option2)
        {
            string playerChoice = "";
            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine(prompt);
                Console.WriteLine("1: " + option1);
                Console.WriteLine("2: " + option2);

                playerChoice = Console.ReadLine();

                if (playerChoice != "1" && playerChoice != "2")
                {
                    Console.WriteLine("Invalid Input.\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();  
                }
               
            }
            return playerChoice;
        }

        void Array(int[] numbers)
        {

            for (int TimesWeveLooped = 0; TimesWeveLooped != numbers.Length; TimesWeveLooped++)
            {
                Console.WriteLine(numbers[TimesWeveLooped]);
            }
        }

        void PrintReverse(int[] values)
        {
            for (int i= values.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(values[i]);
            }
        }

        void Update()
        {
            //       prompt = "Choose a character"
            GetInput("Choose a character", "Bob", "Jim");
        }

        public void Run()
        {
            Weapon Stellar = new Weapon();

            Stellar.Weight();
            Stellar.Durability();
            Stellar.Damage();

            Character Perma = new Character();

            Perma.Move();
            Perma.Attack();
            Perma.Speak();

            return;
        }


    }
}
