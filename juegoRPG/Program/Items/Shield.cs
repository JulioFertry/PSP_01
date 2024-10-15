namespace juegoRPG.Program.Items;

public class Shield: Protection
{
    public override string Name => "Escudo";
    public override int Armor => 6;

    public override void Apply(Character owner)
    {
        owner.BaseArmor += Armor;
        Console.WriteLine($"¡{owner.Name} se ha equipado {Name}!");
    }
    
    public override void Unapply(Character owner)
    {
        owner.BaseArmor -= Armor;
        Console.WriteLine($"¡{owner.Name} se ha desequipado {Name}!");
    }
}