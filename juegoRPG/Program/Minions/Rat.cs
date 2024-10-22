namespace juegoRPG.Program.Minions;

public class Rat: Minion
{
    public override string Name => "Rata";
    public override int Damage => 5;
    
    
    public override int Attack()
    {
        return Damage;
    }
}