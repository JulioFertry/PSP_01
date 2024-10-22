namespace juegoRPG.Program.Items;
using Perks;


public class Shield: Protection
{
    public override string Name => "Escudo";
    public override int Armor => 6;
    private Perk ProtectionPerk => new BerserkerEffect();
    

    public override int Apply()
    {
        return Armor + ProtectionPerk.ApplyEffect();
    }
}