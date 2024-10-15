namespace juegoRPG.Program.Items;

public class Axe: Weapon
{
    public override string Name => "Hacha enorme";
    public override int Damage => 7;

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