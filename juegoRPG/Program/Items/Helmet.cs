namespace juegoRPG.Program.Items;
using Perks;
using Players;

public class Helmet: Protection
{
    public override string Name => "Casco";
    public override int Armor => 2;
    public int ExtraHp = 12;
    public override List<IPerk> Perks => new List<IPerk>();

    public override void Apply(Character owner)
    {
        Console.WriteLine($"¡{owner.Name} se ha equipado {Name}!");
    }
    
    public override void Unapply(Character owner)
    {
        Console.WriteLine($"¡{owner.Name} se ha desequipado {Name}!");
    }
}