using System;

namespace deliverable_two
{
    class Program
    {
        /*
         Grading Rubric: This is graded out of 10 points. You must score 8 or more points
        on each deliverable in Lab 1 to pass.
        1 point each. No partial credit is allowed on an individual point. Credit will be
        granted for any points that are written correctly themselves but don’t run correctly
        because of a problem elsewhere in the program.
        1. Correctly gets user input from the console.
        2. Stores first user input in a variable named headsOrTailsGuess.
        3. Stores second user input in a numeric variable named numberOfFlips.
        4. Loops the correct number of times.
        5. Generates random numbers each time.
        6. Correctly generates and displays a random heads or tails each time.
        7. Adds to correctCount accurately.
        8. Displays the user choice at the end (either heads or tails).
        9. Displays the correct count at the end.
        10.Displays the correct percentage at the end.        
         */

        static void Main(string[] args)
        {
            string headsOrTailGuess = "";
            int numberOfFlips = 0;
            int correctCount = 0;
            string userInput;
            Random coinFlip = new Random();

            Console.WriteLine("Hello and welcome to heads or tails!" + "\r\n" + "Please guess on which side of the coin will come up more, Heads or Tails:");
            headsOrTailGuess = Console.ReadLine();

            Console.WriteLine("How many times would you like to flip this coin?");
            userInput = Console.ReadLine();
            bool sucess = int.TryParse(userInput, out numberOfFlips);

            for (int i = 0; i < numberOfFlips; i++)
            {
                int resultOfFlip = coinFlip.Next(1, 3);

                if (resultOfFlip == 1 && headsOrTailGuess == "Heads" || resultOfFlip == 1 && headsOrTailGuess == "heads")
                {
                    Console.WriteLine("Heads");
                    correctCount++;
                }
                else if (resultOfFlip == 1 && headsOrTailGuess == "Tails" || resultOfFlip == 1 && headsOrTailGuess == "tails")
                {
                    Console.WriteLine("Heads");

                }
                else if (resultOfFlip == 2 && headsOrTailGuess == "Tails" || resultOfFlip == 2 && headsOrTailGuess == "tails")
                {
                    Console.WriteLine("Tails");
                    correctCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                }
            }

            int correctPercetage = (int)Math.Round((double)(100 * correctCount)) / numberOfFlips;
            

            Console.WriteLine($"Your guess was {headsOrTailGuess}. In the {numberOfFlips} times the coin was flipped, {headsOrTailGuess} came up {correctCount} times." + "\r\n" +
                $"You were correct {correctPercetage}% of the times.");

            Console.ReadKey();
        }
    }
}
