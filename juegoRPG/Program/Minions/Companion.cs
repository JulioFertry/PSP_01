namespace juegoRPG.Program.Minions;

public abstract class Companion: IMinion
{
    
    public abstract string Name { get; }
    public abstract int MaxHitPoints { get; }
    public abstract int HitPoints { get; }
    public abstract int BaseDamage { get; }
    public abstract int BaseArmor { get; }
    
    public abstract void Attack();
    public abstract void Die();
    
}