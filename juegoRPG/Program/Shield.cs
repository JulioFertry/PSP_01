namespace juegoRPG.Program;

public class Shield: Protection
{
    public override string Name => "Escudo";
    public override int Armor => 6;

    public override void Apply(Character owner)
    {
        Console.WriteLine($"¡{owner.Name} se ha equipado {Name}!");
    }
}