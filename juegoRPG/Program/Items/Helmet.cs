namespace juegoRPG.Program.Items;


public class Helmet: Protection
{
    public override string Name => "Casco";
    public override int Armor => 7;
    

    public override int Apply()
    {
        return Armor;
    }
}