namespace juegoRPG.Program.Perks;

public class BerserkerEffect: Perk
{
    private int _defense = 2;

    
    public override int ApplyEffect()
    {
        return _defense;
    }
}