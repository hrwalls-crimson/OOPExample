namespace mis_321_pa5_hrwalls_crimson
//This is the class for the actual logic of the turn takings and whatnot. 
{
public class Maelstrom
{
    private Player player1;
    private Player player2;
    private bool player1Turn = true;

    //The previous code instantiates the players, while the code following this serves as a constructor for the game, allowing people
    //to insert preexisting characters.
    public Maelstrom(Player player1, Player player2)
    {
        this.player1 = player1;
        this.player2 = player2;
    }

    public void StartMaelstrom()
    {
        //This is a simple menu that checks to see if both players are alive. If both are, it then checks for whose turn it is, and then they may choose their action
        while (player1.ChosenCharacter.charHealth > 0 && player2.ChosenCharacter.charHealth > 0)
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();


            if (player1Turn)
            {
                Console.WriteLine($"{player1.playerName}'s Turn");
                DisplayMenu(player1, player2);
            }
            else
            {
                Console.WriteLine($"{player2.playerName}'s Turn");
                DisplayMenu(player2, player1);
            }

            player1Turn = !player1Turn;
        }
//If both aren't alive, it ends the game.
        EndGame();
    }

    private void DisplayMenu(Player currentPlayer, Player opponent)
    {
        //This method displays a menu for each turn. It lets the player pick their action, whether its attack, defense, or a show stats.
        bool turnComplete = false;

        while (!turnComplete)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1: Attack");
            Console.WriteLine("2: Defend");
            //Attack and defense are both seperate classes inheriting from IAction, but I decided it would be easier for the show stats to just be endemic? to the character class itself.
            Console.WriteLine("3: Show Stats");
            int choice = GetPlayerChoice();

            switch (choice)
            {
                case 1:
                    new Attack().ActionTaken(currentPlayer, opponent);
                    turnComplete = true;
                    break;
                case 2:
                    new Defense().ActionTaken(currentPlayer, opponent);
                    turnComplete = true;
                    break;
                case 3:
                    currentPlayer.ChosenCharacter.ShowAllStats();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private int GetPlayerChoice()
    {
        //Simple method to parse whether or not the player made a valid choice.
        int choice;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 3)
            {
                break;
            }
            Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
        }
        return choice;
    }

    private void EndGame()
    {
        //When a character has no health, the game ends and they lose.
        Console.Clear();
        if (player1.ChosenCharacter.charHealth <= 0)
        {
            Console.WriteLine($"{player2.playerName} wins!");
        }
        else if (player2.ChosenCharacter.charHealth <= 0)
        {
            Console.WriteLine($"{player1.playerName} wins!");
        }
        Console.WriteLine("Game Over! Press any key to return to the main menu");
        Console.ReadKey();
Console.Clear();
MainMenu MainMenu1 = new MainMenu();

MainMenu1.DisplayMenu();
    }
}

}