namespace juegoRPG.Program.Minions;

public class Golem: Companion
{
    public override string Name => "Golem";
    public override int MaxHitPoints => 150;
    public override int HitPoints => 150;
    public override int BaseArmor => 10;
    public override int BaseDamage => 2;

    public override void Attack()
    {
        throw new NotImplementedException();
    }

    public override void Die()
    {
        throw new NotImplementedException();
    }
}