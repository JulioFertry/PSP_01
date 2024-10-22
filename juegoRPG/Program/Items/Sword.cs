namespace juegoRPG.Program.Items;
using Perks;


public class Sword: Weapon
{
    public override string Name => "Espada bastarda";
    public override int Damage => 4;
    private Perk WeaponPerk => new FlameEffect();
    

    public override int Apply()
    {
        return Damage + WeaponPerk.ApplyEffect();
    }
}