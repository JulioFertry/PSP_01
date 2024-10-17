namespace juegoRPG.Program.Items;
using Perks;
using Players;

public class Shield: Protection
{
    public override string Name => "Escudo";
    public override int Armor => 6;
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