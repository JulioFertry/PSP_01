namespace juegoRPG.Program;

public class Axe: Weapon
{
    public override string Name => "Hacha enorme";
    public override int Damage => 7;

    public override void Apply(Character owner)
    {
        Console.WriteLine($"¡{owner.Name} se ha equipado {Name}!");
    }
}