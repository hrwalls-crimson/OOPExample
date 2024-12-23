namespace mis_321_pa5_hrwalls_crimson
{
    //This is the money maker. This is the abstract class that all three characters inhereit from.
    public abstract class Character
    {
        public string charName { get; set; }

        public double charMaxPower { get; set; }

        public double charHealth { get; set; }

        public double charAttackStrength { get; set; }

        public double charDefensivePower { get; set; }

        public double charPlayerID { get; set; }

        public void ShowAllStats()
        {
            System.Console.WriteLine(@$"Hello {charName}. Your stats are as follows. 
            Max Power: {charMaxPower} 
            Attack Strength: {charAttackStrength} 
            Defensive Power: {charDefensivePower} 
            Current Health: {charHealth}
            ");
        }

public void GeneratePower()
{
    //Randomly generates the power for the character, between 1 and 100
    Random random = new Random();
    charMaxPower = Math.Round(random.NextDouble() * 99 + 1, 2);
}

public void GenerateAttackStrength()
{
        //Randomly generates the attack strength for the character.
    Random random = new Random();
    charAttackStrength = Math.Round(1 + random.NextDouble() * (charMaxPower - 1), 2);
}

public void GenerateDefensivePower()

//Randomly generates the defensive power for the character.
{
    Random random = new Random();
    charDefensivePower = Math.Round(1 + random.NextDouble() * (charMaxPower - 1), 2);
}

    }}