namespace juegoRPG.Program.Minions;

public class Ghost: Summon
{
    public override string Name => "Fantasma";
    public override int BaseDamage => 4;

    public override void Attack()
    {
        throw new NotImplementedException();
    }

    public override void Die()
    {
        throw new NotImplementedException();
    }
}