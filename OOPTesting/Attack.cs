namespace mis_321_pa5_hrwalls_crimson
{
public class Attack : IAction
{
    public void ActionTaken(Player attacker, Player defender)
    {

        //Defines the attacker and defender, while also setting typeBonus to 1
        double attackPower = attacker.ChosenCharacter.charAttackStrength;
        double defensePower = defender.ChosenCharacter.charDefensivePower;
        double typeBonus = 1.0;


        //Checks to see if a type bonus is applicable in the attack, and then sets it if its true
        if ((defender.ChosenCharacter is JackSparrow && attacker.ChosenCharacter is DavyJones) ||
            (defender.ChosenCharacter is DavyJones && attacker.ChosenCharacter is WillTurner) ||
            (defender.ChosenCharacter is WillTurner && attacker.ChosenCharacter is JackSparrow))
        {
            typeBonus = 1.2;
        }

        double damage = (double)((attackPower - defensePower) * typeBonus);
        damage = Math.Max(damage, 1);
        defender.ChosenCharacter.charHealth -= damage;

        Console.WriteLine($"{attacker.playerName} attacks {defender.playerName}!");
        Console.WriteLine($"Damage dealt: {damage}");
        Console.WriteLine($"{defender.playerName}'s remaining health: {defender.ChosenCharacter.charHealth}");
    }
}

}