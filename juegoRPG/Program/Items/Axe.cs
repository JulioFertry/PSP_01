namespace juegoRPG.Program.Items;


public class Axe : Weapon
{
    public override string Name => "Hacha Enorme";
    public override int Damage => 7;
    

    public override int Apply()
    {
        return Damage;
    }
}