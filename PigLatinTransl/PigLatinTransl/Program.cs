using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinTransl
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int positionOfVowel = -1;

            Console.WriteLine("Welcome to the Pig Latin translator:");
            Console.WriteLine("Enter-way ext-tay");
            // input for PLTranslations
            string userInput = Console.ReadLine();

            StringBuilder pigLatinPrefix = new StringBuilder();

            for (int n = 0; n < userInput.Length; n++)
            {
                //int findVowel();
                //Console.WriteLine($"{PLRoot}{PLPrefix}");
                //userInput.Substring(startIndex: n);
                
                switch (userInput[n])
                {

                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        string PLRoot = userInput.Substring(n, userInput.Length);
                        return;

                    default:
                        string PLPrefix = userInput.Substring(userInput.Length, n);
                        return;
                }

            }
            Console.ReadKey();
            if (positionOfVowel == -1)
            {
                Console.WriteLine(userInput);
            }
        }
                   
    }
}

