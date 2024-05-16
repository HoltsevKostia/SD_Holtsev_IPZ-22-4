using ClassLibrary.GameTemplate;

bool playAgain = true;

while (playAgain)
{
    Console.Clear();
    Console.WriteLine("Welcome to Blackjack!");

    BlackjackGame game = new ConsoleBlackjackGame();
    game.PlayGame();

    Console.WriteLine("Game over. Would you like to play again? (y/n)");
    string input = Console.ReadLine();
    playAgain = input.ToLower() == "y";
}

Console.WriteLine("Thanks for playing!");