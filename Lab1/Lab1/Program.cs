using System;
using System.Collections.Generic;
using LectureCode;
using PG2Input;

namespace Lab1
{
    class Program
    {
        private static Dictionary<string, int> speechDictionary;
        static void Main(string[] args)
        {
#if DEBUG
            Lectures.Run();
#endif
            // variables
            String[] options = { "1. The Speech", "2. List of Words", "3. Show Histogram", "4. Search for Word", "5. Remove Word", "6. Exit" };
            int selection;

            speechDictionary = GetSpeechDict();


            while (true)
            {
                Input.ReadChoice("Choice?", options, out selection);
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(GetSpeech());
                        break;
                    case 2:
                        Console.Clear();
                        String speech = GetSpeech();
                        Char[] delimiters = {' ', ',', '.', ';', ':', '!', '\n', '\t', '\r'};
                        List<String>  speechWords = new(speech.Split(delimiters, StringSplitOptions.RemoveEmptyEntries));
                        foreach (String word in speechWords)
                        {
                            Console.WriteLine(word);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        foreach(var word in speechDictionary)
                        {
                            WriteFullLine(word.Key, word.Value);
                        }
                        break;
                    case 4:
                        string wordValue = "";
                        Input.ReadString("What word do you want to find?", ref wordValue);
                        if (speechDictionary.ContainsKey(wordValue))
                        {
                            WriteFullLine(wordValue, speechDictionary.GetValueOrDefault(wordValue));
                            printSentences(wordValue);
                        }

                        break;
                    case 5:
                        string removeValue = "";
                        Input.ReadString("What word you want to remove?", ref removeValue);
                        int dictCountBeforeRemoval = speechDictionary.Count;
                        speechDictionary.Remove(removeValue);
                        int dictCountAfterRemoval = speechDictionary.Count;
                        if(dictCountAfterRemoval == dictCountBeforeRemoval)
                        {
                            Console.WriteLine(removeValue + " not in the dictionary");
                        }
                        else
                        {
                            Console.WriteLine(removeValue + " is removed from the dictionary");
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }

        }

        private static string GetSpeech()
        {
            string text = "I say to you today, my friends, so even though we face the difficulties of today and tomorrow, I still have a dream. It is a dream deeply rooted in the American dream. " +
            "I have a dream that one day this nation will rise up and live out the true meaning of its creed: We hold these truths to be self-evident: that all men are created equal. " +
            "I have a dream that one day on the red hills of Georgia the sons of former slaves and the sons of former slave owners will be able to sit down together at the table of brotherhood. " +
            "I have a dream that one day even the state of Mississippi, a state sweltering with the heat of injustice, sweltering with the heat of oppression, will be transformed into an oasis of freedom and justice. " +
            "I have a dream that my four little children will one day live in a nation where they will not be judged by the color of their skin but by the content of their character. " +
            "I have a dream today. I have a dream that one day, down in Alabama, with its vicious racists, with its governor having his lips dripping with the words of interposition and nullification; one day right there in Alabama, little black boys and black girls will be able to join hands with little white boys and white girls as sisters and brothers. " +
            "I have a dream today. I have a dream that one day every valley shall be exalted, every hill and mountain shall be made low, the rough places will be made plain, and the crooked places will be made straight, and the glory of the Lord shall be revealed, and all flesh shall see it together. " +
            "This is our hope. This is the faith that I go back to the South with. With this faith we will be able to hew out of the mountain of despair a stone of hope. With this faith we will be able to transform the jangling discords of our nation into a beautiful symphony of brotherhood. " +
            "With this faith we will be able to work together, to pray together, to struggle together, to go to jail together, to stand up for freedom together, knowing that we will be free one day. " +
            "This will be the day when all of God's children will be able to sing with a new meaning, My country, 'tis of thee, sweet land of liberty, of thee I sing. Land where my fathers died, land of the pilgrim's pride, from every mountainside, let freedom ring. " +
            "And if America is to be a great nation this must become true. So let freedom ring from the prodigious hilltops of New Hampshire. Let freedom ring from the mighty mountains of New York. Let freedom ring from the heightening Alleghenies of Pennsylvania! " +
            "Let freedom ring from the snowcapped Rockies of Colorado! Let freedom ring from the curvaceous slopes of California! But not only that; let freedom ring from Stone Mountain of Georgia! " +
            "Let freedom ring from Lookout Mountain of Tennessee! Let freedom ring from every hill and molehill of Mississippi. From every mountainside, let freedom ring. " +
            "And when this happens, when we allow freedom to ring, when we let it ring from every village and every hamlet, from every state and every city, we will be able to speed up that day when all of God's children, black men and white men, Jews and Gentiles, Protestants and Catholics, will be able to join hands and sing in the words of the old Negro spiritual, Free at last! free at last! thank God Almighty, we are free at last!";


            return text;
        }

        private static Dictionary<String, int> GetSpeechDict()
        {
            String speech3 = GetSpeech();
            Char[] delimiters3 = { ' ', ',', '.', ':', ';', '!', '\n', '\t', '\r' };
            List<String> speechWords3 = new(speech3.Split(delimiters3, StringSplitOptions.RemoveEmptyEntries));
            Dictionary<String, int> speechWordsDict = new();
            foreach (String word in speechWords3)
            {
                if (speechWordsDict.ContainsKey(word))
                {
                    speechWordsDict[word]++; 
                }
                else
                {
                    speechWordsDict.Add(word, 1); 
                }
            }
            return speechWordsDict;
        }

        private static void printSentences(String word)
        {
            char[] delimiters = { '.', '!' };
            String[] sentences = GetSpeech().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Boolean flag = true;
            foreach (String sentence in sentences)
            {
                if (sentence.Contains(word))
                {
                    Console.WriteLine(sentence);
                    flag = false;
                }
            }

            if (flag)
            {
                Console.WriteLine(word + " is not found");
            }
        }

        private static void WriteFullLine(string word, int value)
        {
            Console.Write("{0,20}", word);
            Console.Write("{0,5}", ' ');
            string barLine = new string(' ', value);
            // Write an entire line to the console with the string.
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(barLine);
            Console.ResetColor();
            Console.Write(" " + value);
            Console.WriteLine("\n");
            // Reset the color.
            
        }


    }
}
