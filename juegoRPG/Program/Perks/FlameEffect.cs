namespace juegoRPG.Program.Perks;

public class FlameEffect: Perk
{
    private int _damage = 8;

    
    public override int ApplyEffect()
    {
        return _damage;
    }
}