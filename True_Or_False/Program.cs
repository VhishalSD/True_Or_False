using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            string[] questions = {
            "The sun is a star",
            "Water boils at 100 degrees Celsius",
            "Cats can fly",
            "Earth is the third planet from the sun",
            "Bananas are vegetables"
            };

            bool[] answers = { true, true, false, true, false };

            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine($"Warning! questions has {questions.Length} items, but answers has {answers.Length}.");
            }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True or false?");
                string input = Console.ReadLine().ToLower();

                isBool = (input == "true" || input == "false");

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine().ToLower();
                    isBool = (input == "true" || input == "false");
                }

                inputBool = (input == "true") ? true : false;

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];

                Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");

                if (response == answer)
                {
                    score++;
                }

                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }
    }
}

