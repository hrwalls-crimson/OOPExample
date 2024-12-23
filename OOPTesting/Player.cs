namespace mis_321_pa5_hrwalls_crimson
{
public class Player
{

    //Creates a simple player object to track the name, character, and id. Also allows for the tracking of the riposte ability!
    public string playerName { get; set; }
    public int playerID { get; set; }
    public Character ChosenCharacter { get; set; } 

    public Player(int id, string name, Character character)
    {
        playerID = id;
        playerName = name;
        ChosenCharacter = character;
    }

    public bool IsRiposte = false;
}
}