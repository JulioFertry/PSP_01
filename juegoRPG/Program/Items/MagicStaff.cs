namespace juegoRPG.Program.Items;

public class MagicStaff: Weapon
{
    public override string Name => "Bastón Mágico";
    public override int Damage => 2;

    public override void Apply(Character owner)
    {
        owner.BaseDamage += Damage;
        Console.WriteLine($"¡{owner.Name} se ha equipado {Name}!");
    }
    
    public override void Unapply(Character owner)
    {
        owner.BaseDamage -= Damage;
        Console.WriteLine($"¡{owner.Name} se ha desequipado {Name}!");
    }
}