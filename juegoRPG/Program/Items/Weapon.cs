namespace juegoRPG.Program.Items;

public abstract class Weapon: IItem
{
    public abstract string Name { get; }
    public abstract int Damage { get; }
    
    public abstract void Apply(Character character);
    public abstract void Unapply(Character character);
}