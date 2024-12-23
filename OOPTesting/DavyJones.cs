namespace mis_321_pa5_hrwalls_crimson
{
    public class DavyJones : Character
    {
        public bool WeakToWill = true;

            //Allows a generation method for davy jones
           public void GenerateDavyJones(){
            charName = "Davy";
            GeneratePower();
            GenerateAttackStrength();
            GenerateDefensivePower();
            charHealth = 100;
        }
    }
}