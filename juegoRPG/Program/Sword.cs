namespace juegoRPG.Program;

public class Sword: Weapon
{
    public override string Name => "Espada bastarda";
    public override int Damage => 4;

    public override void Apply(Character owner)
    {
        Console.WriteLine($"¡{owner.Name} se ha equipado {Name}!");
    }
}