namespace juegoRPG.Program.Minions;
using Perks;


public class Ghost: Minion
{
    public override string Name => "Fantasmico";
    public override int Damage => 2;
    public Perk MinionAbility { get; private set; }

    
    public Ghost()
    {
        MinionAbility = new FlameEffect();
    }
    
    
    public override int Attack()
    {
        return Damage + MinionAbility.ApplyEffect();
    }
    
}