namespace juegoRPG.Program;

public class Helmet: Protection
{
    public override string Name => "Casco";
    public override int Armor => 2;
    public int ExtraHp = 12;

    public override void Apply(Character owner)
    {
        owner.MaxHitPoints += ExtraHp;
        owner.HitPoints += ExtraHp;
        Console.WriteLine($"¡{owner.Name} se ha equipado {Name}!");
    }
}