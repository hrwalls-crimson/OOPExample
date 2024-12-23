namespace mis_321_pa5_hrwalls_crimson
{
public class Defense : IAction
{
    public void ActionTaken(Player defender, Player attacker)
    {
        Console.WriteLine($"{defender.playerName} chooses to defend!");
        defender.ChosenCharacter.charDefensivePower *= 2;

        Random rand = new Random();
        if (rand.Next(100) < 15)
        {
            //This isn't huge but I thought it was a really cool idea. Essentially, instead of just blocking, it turns the book isriposte into true.
            //A riposte is kind of a counter. So when riposte is true (15% chance it is), the opponent loses their turn.
            //Furthermore, defense doubles the characters defensive power.
            Console.WriteLine($"{defender.playerName} enters a riposte state! The opponent loses their next turn.");
            attacker.IsRiposte = true;
        }
    }
}

}