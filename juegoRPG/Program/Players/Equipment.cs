using juegoRPG.Program.Items;

namespace juegoRPG.Program.Players;

public class Equipment
{
    public Protection? Protection;
    public Weapon? Weapon;


    public void EquipProt(Protection protection)
    {
        this.Protection = protection;
    }

    public void EquipWeap(Weapon weapon)
    {
        this.Weapon = weapon;
    }

    public void DeleteProt()
    {
        this.Protection = null;
    }

    public void DeleteWeap()
    {
        this.Weapon = null;
    }
}