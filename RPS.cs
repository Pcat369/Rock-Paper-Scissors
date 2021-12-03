using System;

namespace Rock_Paper_Scissors
{
    class RPS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            Console.WriteLine("Player 1: Please enter your choice.");

            string player1 = Console.ReadLine();

            Console.WriteLine("Thank you, Player 1");

            Console.WriteLine("");

            Console.WriteLine("Player 2: Please enter your choice.");

            string player2 = Console.ReadLine();

            Console.WriteLine("Thank you, Player 2");

            Console.WriteLine("");

            playRPS(player1, player2);
        }

        public static void playRPS(string player1, string player2)
        {

            if (player1 == player2)
            {
                Console.WriteLine("Tie!");
            }
            else if (player1 == "Paper" && player2 == "Rock")
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if (player1 == "Rock" && player2 == "Scissors")
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if (player1 == "Scissors" && player2 == "Paper")
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if (player2 == "Paper" && player1 == "Rock")
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else if (player2 == "Rock" && player1 == "Scissors")
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else if (player2 == "Scissors" && player1 == "Paper")
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else
            {
                Console.WriteLine("Incorrect Input. Please choose either Rock, Paper. or Scissors");
            }
        }
    }
}
