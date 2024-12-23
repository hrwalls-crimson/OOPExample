namespace mis_321_pa5_hrwalls_crimson
{
    public class WillTurner : Character
    {
        public bool WeakToJack = true;


        public void GenerateWillTurner(){
            charName = "Will Turner";
            GeneratePower();
            GenerateAttackStrength();
            GenerateDefensivePower();
            charHealth = 100;
        }
    }
}