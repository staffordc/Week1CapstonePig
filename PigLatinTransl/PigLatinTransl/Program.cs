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
            string PLSingWord = null;
            string PLYWord = null;

            for (int n = 0; n < userInput.Length; n++) //= positionOfVowel();
            {
                //PLPrefix = userInput.Substring(startIndex: n);
                //PLRoot = userInput.Substring(n: endIndex);
                //Console.WriteLine($"{PLRoot}{PLPrefix}");
                if (PLSingWord != null)
                {
                    break;
                }
                if (PLYWord != null)
                {
                    break;
                }

                switch (userInput[n])
                {

                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        string PLRoot = userInput.Substring(n, userInput.Length - n);
                        string PLPrefix = userInput.Substring(0, n);
                        PLSingWord = $"{PLRoot}-{PLPrefix}ay";
                        // return;
                        break;
                    case 'y':
                        string PLYRoot = userInput.Substring(n, userInput.Length - n);
                        string PLYPrefix = userInput.Substring(0, n);
                        PLYWord = $"{PLYRoot}-{PLYPrefix}ay";
                        break;


                    default:
                       // string PLPrefix = userInput.Substring(userInput.Length, n);
                        // return;
                        break;
                        
                    
                }

            }
            Console.WriteLine(PLSingWord);
            Console.WriteLine(PLYWord);
            Console.ReadKey();
            if (positionOfVowel == -1)
            {
                Console.WriteLine(userInput);
            }
        }
                   
    }
}

