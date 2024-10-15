namespace juegoRPG.Program.Items;

public class Sword: Weapon
{
    public override string Name => "Espada bastarda";
    public override int Damage => 4;

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