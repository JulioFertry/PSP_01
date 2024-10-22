using juegoRPG.Program.Players;

namespace juegoRPG.Program.Items;


public abstract class Weapon: IItem
{
    public Character? Owner { get; private set; } = null;
    public abstract string Name { get; }
    public abstract int Damage { get; }


    public void SetOwner(Character owner)
    {
        Owner = owner;
        Console.WriteLine($"{Owner.Name} ahora tiene un {Name}");
    }
    
    public abstract int Apply();
}