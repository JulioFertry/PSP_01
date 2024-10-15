namespace juegoRPG.Program.Items;

public abstract class Protection: IItem
{
    public abstract string Name { get; }
    public abstract int Armor { get; }
    
    public abstract void Apply(Character character);
    public abstract void Unapply(Character character);
}