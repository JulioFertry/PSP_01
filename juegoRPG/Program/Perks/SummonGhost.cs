using juegoRPG.Program.Minions;
using juegoRPG.Program.Players;

namespace juegoRPG.Program.Perks;

public class SummonGhost: Perk
{
    public override int ApplyEffect()
    {
        return 0;
    }

    public void Summon(Character character)
    {
        Ghost ghost = new Ghost();
        character.Summons.Add(ghost);
        Console.WriteLine($"{character} ha invocado un fantasma!");
    }
}