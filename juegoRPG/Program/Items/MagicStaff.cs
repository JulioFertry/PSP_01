using juegoRPG.Program.Perks;

namespace juegoRPG.Program.Items;


public class MagicStaff: Weapon
{
    public override string Name => "Bastón Mágico";
    public override int Damage => 1;
    private SummonGhost WeaponPerk => new SummonGhost();


    public override int Apply()
    {
        WeaponPerk.Summon(Owner);
        return Damage + WeaponPerk.ApplyEffect();
    }
}