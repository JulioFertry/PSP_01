namespace juegoRPG.Program.Minions;


public abstract class Minion
{
    public abstract string Name { get; }
    public abstract int Damage { get; }
    
    
    public abstract int Attack();
}