namespace juegoRPG.Program.Items;
using Players;

public interface IItem
{
    void Apply(Character character);
    void Unapply(Character character);
}