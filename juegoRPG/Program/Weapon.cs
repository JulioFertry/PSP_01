namespace juegoRPG.Program;

public abstract class Weapon: IItem
{
    public abstract string Name { get; }
    public abstract int Damage { get; }
    
    public abstract void Apply(Character character);
}