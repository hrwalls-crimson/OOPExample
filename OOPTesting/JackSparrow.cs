namespace mis_321_pa5_hrwalls_crimson
{
    public class JackSparrow : Character
    {
        public bool WeakToDavy = true;

        public void GenerateJackSparrow()
        {
            charName = "Jack Sparrow";
            GeneratePower();
            GenerateAttackStrength();
            GenerateDefensivePower();
            charHealth = 100;
        }
    }
}