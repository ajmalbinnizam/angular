using System;

public class spc
{
	public spc()
	{
        {

//            using System;

//namespace Helloworld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string ans = "";
//            int count = 0;
//            int count1 = 0;

//            Console.WriteLine("Welcome to RPS game");

//            while (ans != "NO")
//            {
//                Console.WriteLine("Select any one:\n1->ROCK\n2->PAPER\n3->SCISSOR");
//                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
//                Random rnd = new Random();
//                int n = rnd.Next(0, 3);
//                Console.WriteLine("Enter your choice:");
//                string user = Console.ReadLine().ToUpper();
//                Console.WriteLine("Computer:" + choices[n]);

//                if (user == "ROCK" && choices[n] == "SCISSOR")
//                {
//                    Console.WriteLine("User wins");
//                    count += 1;
//                }
//                else if (user == "ROCK" && choices[n] == "PAPER")
//                {
//                    Console.WriteLine("Computer wins");
//                    count1 += 1;
//                }
//                else if (user == "PAPER" && choices[n] == "ROCK")
//                {
//                    Console.WriteLine("User wins");
//                    count += 1;
//                }
//                else if (user == "PAPER" && choices[n] == "SCISSOR")
//                {
//                    Console.WriteLine("Computer Wins");
//                    count1 += 1;
//                }
//                else if (user == "SCISSOR" && choices[n] == "ROCK")
//                {
//                    Console.WriteLine("Computer Wins");
//                    count1 += 1;
//                }
//                else if (user == "SCISSOR" && choices[n] == "PAPER")
//                {
//                    Console.WriteLine("User wins");
//                    count += 1;
//                }
//                else
//                {
//                    Console.WriteLine("Same choices");
//                }
//                Console.WriteLine("Do u want to continue(YES/NO):");
//                ans = Console.ReadLine().ToUpper();
//                Console.WriteLine("---------------------------------------");
//            }
//            Console.WriteLine("User wins " + count + " times");
//            Console.WriteLine("Computer wins " + count1 + " times");
//        }
//    }
//}

        }

        Random random = new Random();
        String computer; String player;
        bool playAgain = true;
        String response;

        while (playAgain)
        {
            player = "";
            computer = "";
            response = "";
            while (player != "ROCK" && player != "PAPER" && player != "SCISSOR")
            {
                Console.Write("Enter rock paper scissor: ");
                player = Console.ReadLine();
                player = player.ToUpper();
            }
            switch (random.Next(1, 4))
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSOR";
                    break;
            }
            Console.WriteLine("Player: " + player);
            Console.WriteLine("computer: " + computer);

            switch (player)
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("it's draw");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("you win");
                    }
                    else
                    {
                        Console.WriteLine("you lose");
                    }
                    break;
                case "PAPER":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("you win");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("it's draw");
                    }
                    else
                    {
                        Console.WriteLine("you lose");
                    }
                    break;
                case "SCISSOR":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("you lose");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("you win");
                    }
                    else
                    {
                        Console.WriteLine("it's a draw");
                    }
                    break;
            }
            Console.Write("would you like to play again Y/N ");
            response = Console.ReadLine();
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
    }
}
