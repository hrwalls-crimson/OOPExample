namespace mis_321_pa5_hrwalls_crimson
{
    public class MainMenu
    {
        public int userCharChoice { get; set; }
        public int userChar2Choice { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public void DisplayMenu()
        {
            Console.WriteLine("Hello and Welcome to Calypso's Maelstrom!");
            Console.WriteLine();

            Console.WriteLine("Player 1, please enter your name:");
            string player1Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Your options for characters are:");
            Console.WriteLine("1: Captain Jack Sparrow");
            Console.WriteLine("2: Will Turner");
            Console.WriteLine("3: Davy Jones");
            userCharChoice = GetCharacterChoice();

            Player1 = CreatePlayer(1, player1Name, userCharChoice);

            Console.Clear();
            Console.WriteLine("Player 2, please enter your name:");
            string player2Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Your options for characters are:");
            Console.WriteLine("1: Captain Jack Sparrow");
            Console.WriteLine("2: Will Turner");
            Console.WriteLine("3: Davy Jones");
            userChar2Choice = GetCharacterChoice(exclude: userCharChoice);

            Player2 = CreatePlayer(2, player2Name, userChar2Choice);

            Console.Clear();
            Console.WriteLine("Your fighters are chosen! May the better pirate win!");
            Console.WriteLine($"Player 1: {Player1.playerName}, Character: {Player1.ChosenCharacter.charName}");
            Console.WriteLine($"Player 2: {Player2.playerName}, Character: {Player2.ChosenCharacter.charName}");
            Console.WriteLine("Press any key to start the game...");
            Console.ReadKey();
            StartMaelstrom();
        }

        private int GetCharacterChoice(int exclude = -1)
        {
            int choice;
            do
            {
                Console.Write("Choose your character: ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 3 && choice != exclude)
                {
                    break;
                }
                Console.WriteLine("Invalid choice or character already taken. Try again.");
            } while (true);

            return choice;
        }

        private Player CreatePlayer(int id, string name, int characterChoice)
        {
            Character character = characterChoice switch
            {
                1 => CreateJackSparrow(),
                2 => CreateWillTurner(),
                3 => CreateDavyJones(),
                _ => throw new Exception("Invalid character choice")
            };

            return new Player(id, name, character);
        }

        private JackSparrow CreateJackSparrow()
        {
            var jackSparrow = new JackSparrow();
            jackSparrow.GenerateJackSparrow();
            return jackSparrow;
        }

        private WillTurner CreateWillTurner()
        {
            var willTurner = new WillTurner();
            willTurner.GenerateWillTurner();
            return willTurner;
        }

        private DavyJones CreateDavyJones()
        {
            var davyJones = new DavyJones();
            davyJones.GenerateDavyJones();
            return davyJones;
        }

        private void StartMaelstrom()
        {
            Maelstrom maelstrom = new(Player1, Player2);
            maelstrom.StartMaelstrom();
        }
    }
}
