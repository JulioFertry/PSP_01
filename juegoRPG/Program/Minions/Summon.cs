namespace juegoRPG.Program.Minions;

public abstract class Summon: IMinion
{
    
    public abstract string Name { get; }
    public abstract int BaseDamage { get; }
    
    public abstract void Attack();
    public abstract void Die();
    
}