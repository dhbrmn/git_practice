using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);
           
            // INPUT ARRAYS
            string[] questions = { "Are roses red?", "Is iron a liquid?", "Do pigs fly?", "Is the world round?", "Does anything taste better than pizza?" };
            bool[] answers = { true, false, false, true, false };

            RunQuiz(questions, answers);
            RunQuiz();

        }

        static void RunQuiz(string[] questions, bool[] answers)
        {
            //METHOD TO RUN QUIZ WITH PREDEFINED QUESTIONS AND ANSWERS


            //array equal length check
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Error 101: Strings unequal length! Press Enter to restart.");
                Console.ReadLine();
            }

            //foreach loop
            int askingIndex = 0;
            int score = 0;
            bool[] responses = new bool[questions.Length];

            foreach (string question in questions)
            {
                //print question take answer
                Console.WriteLine($"{questions[askingIndex]} True or false?");
                string input = Console.ReadLine().ToLower();

                //convert answer to bool
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


        static void RunQuiz()
        {
            //METHOD WHERE USER CAN INPUT THE QUESTIONS AND ANSWERS VIA CONSOLE AND THEN LET THE QUIZ RUN

            //DEFINE TWO ARRAYS FOR QUESTIONS AND ANSWERS WITH CUSTOM SET LENGTH

            /*array length definition*/
            Console.WriteLine("How many questions would you like to input?");
            string numberInput = Console.ReadLine();

            bool isInt = Int32.TryParse(numberInput, out int maxIndex);

            while ( isInt == false )
            {
                Console.WriteLine("Invalid input. Please input numbers only.");
                numberInput = Console.ReadLine();
                isInt = Int32.TryParse(numberInput, out maxIndex);
            }

            /*new arrays with previous input length*/
            string[] questions = new string[maxIndex];
            bool[] answers = new bool[maxIndex];
            
            /*foreach loop to fill the array with questions and correct answers*/
            int startIndex = 0;

            foreach (string question in questions)
            {
                Console.WriteLine("Input the next question: ");
                string questionInput = Console.ReadLine();

                questions[startIndex] = questionInput;

                Console.WriteLine("What is the correct answer to this question? Please only use answers like \"true\" or \"false\".");
                string answerInput = Console.ReadLine().ToLower();

                bool isBool = Boolean.TryParse(answerInput, out bool answerOut);

                while (isBool == false)
                {
                    Console.WriteLine("Invalid input. The answer should be \"true\" or \"false\".");
                    Console.WriteLine("Input answer again: ");
                    answerInput = Console.ReadLine().ToLower();
                    isBool = Boolean.TryParse(answerInput, out answerOut);
                }

                answers[startIndex] = answerOut;

                startIndex++;
            }

            //STARTS QUIZ BASED ON PREVIOUS INPUT

            /*new array for responses*/
            bool[] responses = new bool[maxIndex];

            /*foreach loop to input responses on the questions and evaluate the score*/
            int askingIndex = 0;
            int score = 0;


            foreach (string question in questions)
            {
                /*print question take answer*/
                Console.WriteLine($"{questions[askingIndex]} True or false?");
                string input = Console.ReadLine().ToLower();

                /*convert answer to bool*/
                bool isBool2 = bool.TryParse(input, out bool inputBool);

                while (isBool2 == false)
                {
                    Console.WriteLine("Unsupported answer. Please only input \"true\" or \"false\"");
                    input = Console.ReadLine().ToLower();
                    isBool2 = Boolean.TryParse(input, out inputBool);
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
                askingIndex++;

            }

            Console.WriteLine($"You managed to get {score} out of 5 correct!");


        }
    }
}

