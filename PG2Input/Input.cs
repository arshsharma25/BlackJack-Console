using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2Input
{
    public static class Input
    {


        private static int ReadInteger(String prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                String userInput = Console.ReadLine();
                int convertedValue;
                if (int.TryParse(userInput, out convertedValue) && convertedValue > min && convertedValue < max)
                {
                    return convertedValue;
                }
                else
                {
                    Console.WriteLine("That is not an integer. Please try again");
                }
            }
            
            
        }

        public static void ReadString(string prompt, ref string value)
        {
            while (true)
            {
                Console.Write(prompt);
                var userInput = Console.ReadLine();
                if (!String.IsNullOrEmpty(userInput) && !String.IsNullOrWhiteSpace(userInput))
                {
                    value = userInput;
                    break;
                }
            }
        }

        public static void ReadChoice(string prompt, string[] options, out int selection)
        {
            while (true)
            {
                foreach (string option in options)
                {
                    Console.WriteLine(option);
                }
                Console.WriteLine("\n");
                Console.Write(prompt);
                String userInput = Console.ReadLine();
                if(int.TryParse(userInput, out selection))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a number. Please try again.");
                }
            }
        }



    }
}
