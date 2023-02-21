using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make whole app run with a single method RunQuiz(questions[], answers[])
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // arrays
            string[] questions = { "Are roses red?", "Is iron a liquid?", "Do pigs fly?", "Is the world round?", "Does anything taste better than pizza?" };
            bool[] answers = { true, false, false, true, false };
            bool[] responses = new bool[questions.Length];

            //array equal length check
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Error 101: Strings unequal length!");
            }

            //foreach loop
            int askingIndex = 0;
            int score = 0;


            foreach (string question in questions)
            {
                /*print question take answer*/
                Console.WriteLine($"{questions[askingIndex]} True or false?");
                string input = Console.ReadLine().ToLower();
               
                /*convert answer to bool*/
                bool isBool = bool.TryParse(input, out bool inputBool);

                while (isBool == false)
                {
                    Console.WriteLine("Unsupported answer. Please only input \"true\" or \"false\"");
                    input = Console.ReadLine().ToLower();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                
                    responses[askingIndex] = inputBool;
                        

                bool ans = answers[askingIndex];
                bool res = responses[askingIndex];
                int questionNumber = askingIndex + 1;
                Console.WriteLine($"{questionNumber}. Input: {res} | Answer: {ans}");

                if (ans == res)
                {
                    score++;
                }

                Console.WriteLine($"You got {score} out of {questionNumber} correct!");
                ++askingIndex;

            }

            Console.WriteLine($"You managed to get {score} out of 5 correct!");
        }
    }
}

