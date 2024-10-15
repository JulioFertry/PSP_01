namespace juegoRPG.Program.Items;

public interface IItem
{
    void Apply(Character character);
    void Unapply(Character character);
}