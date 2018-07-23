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
            var Repeat = true;

            while (Repeat)
            { 
                Console.WriteLine("Welcome to the Pig Latin translator:");
                Console.WriteLine("Enter-way ext-tay");
                // input for PLTranslations
                string userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                string PLSingWord = null;
                string PLYWord = null;

                for (int n = 0; n < userInput.Length; n++) 
                {
                
                    if (PLSingWord != null)
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
                        
                            if (n == 0)
                            {
                                PLSingWord = $"{PLRoot}-way";
                                break;
                            }
                            PLSingWord = $"{PLRoot}-{PLPrefix}ay";

                        
                            // return;
                            break;
                        case 'y':
                            if (PLYWord != null)
                            {
                                break;
                            }
                            string PLYRoot = userInput.Substring(n, userInput.Length - n);
                            string PLYPrefix = userInput.Substring(0, n);
                            PLYWord = $"{PLYRoot}-{PLYPrefix}ay";
                       
                            break;


                        default:
                        
                            break;
                    }

                
                }
                if (PLSingWord == null && PLYWord == null)
                {
                    Console.WriteLine($"I don't think that's a word");
                }
                Console.WriteLine(PLSingWord);
                Console.WriteLine(PLYWord);
                Repeat = Retry();

            }

            
            //restart?
            bool Retry()
            {
                Console.WriteLine("Want to translate another word? (y/n)");
                String Answer = Console.ReadLine().ToUpper();

                //var enteredYes = new[] { "Y", "YES" }.Contains(Answer);

                if (Answer == "Y" || Answer == "YES")
                {
                    return true;

                }
                else if (Answer == "N" || Answer == "NO")
                {
                    return false;

                }
                else
                {
                    Console.WriteLine("That's Pig Latin to me! (jk, just give me a y or n)");
                    return Retry();

                }
            }
        }
    }
}


