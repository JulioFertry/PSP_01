namespace juegoRPG.Program.Items;

public class Helmet: Protection
{
    public override string Name => "Casco";
    public override int Armor => 2;
    public int ExtraHp = 12;

    public override void Apply(Character owner)
    {
        owner.BaseArmor += Armor;
        owner.MaxHitPoints += ExtraHp;
        owner.HitPoints += ExtraHp;
        Console.WriteLine($"¡{owner.Name} se ha equipado {Name}!");
    }
    
    public override void Unapply(Character owner)
    {
        owner.BaseArmor -= Armor;
        Console.WriteLine($"¡{owner.Name} se ha desequipado {Name}!");
    }
}