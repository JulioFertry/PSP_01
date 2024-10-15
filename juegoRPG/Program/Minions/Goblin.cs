namespace juegoRPG.Program.Minions;

public class Goblin: Companion
{
    public override string Name => "Duende";
    public override int MaxHitPoints => 20;
    public override int HitPoints => 20;
    public override int BaseArmor => 2;
    public override int BaseDamage => 8;

    public override void Attack()
    {
        throw new NotImplementedException();
    }

    public override void Die()
    {
        throw new NotImplementedException();
    }
}