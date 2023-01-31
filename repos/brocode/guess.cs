using System;

public class guess
{
    public guess()
    {
        Random random = new Random();
        int min = 1; int max = 100;
        bool playAgain = true;
        int guess = 0; int guesses = 0;

        while (playAgain)
        {
            int number = random.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("guess a number between " + min + "-" + max);
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("guess: " + guess);
                if (guess < number)
                {
                    Console.WriteLine("your number is too low");
                }
                else if (guess > number)
                {
                    Console.WriteLine("your number is too high");
                }
                guesses++;
            }
            Console.WriteLine("ohoo the random number is " + number + "\n You win");
            Console.WriteLine("Guesses: " + guesses);
            Console.WriteLine("do you want to play again: Y/N ");
            String response = Console.ReadLine();
            response = response.ToUpper();
            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;

            }

        }
        Console.WriteLine("thanks for playing");
        Console.ReadKey();

        {
            //Random random = new Random();
            //int guess; int guesses;
            //bool playAgain = true;
            //while (playAgain)
            //{
            //    guess = 0; guesses = 0;
            //    int number = random.Next(0, 10);
            //    while (guess != number)
            //    {
            //        Console.WriteLine("enter no betweeen 0-10");
            //        guess = Convert.ToInt32(Console.ReadLine());
            //        if (guess < number)
            //        {
            //            Console.WriteLine("guess number is low");
            //        }
            //        else if (guess > number)
            //        {
            //            Console.WriteLine("guess number is high");

            //        }
            //        guesses++;
            //    }
            //    Console.WriteLine("oho you win by " + guesses + "guesses");
            //    Console.WriteLine("wanna play again Y/N: ");
            //    String response = Console.ReadLine();
            //    response = response.ToUpper();
            //    if (response == "Y")
            //    {
            //        playAgain = true;
            //    }
            //    else
            //    {
            //        playAgain = false;
            //    }

            //}

            //Console.WriteLine("Thanks for playing");
        }
    }
}
