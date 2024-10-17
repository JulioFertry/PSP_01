namespace juegoRPG.Program.Items;
using Perks;
using Players;

public class Axe : Weapon
{
    public override string Name => "Hacha enorme";
    public override int Damage => 7;
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