namespace juegoRPG.Program.Players;
using Minions;
using Items;

public class Character
{
    public string Name {get; private set;}
    public Stats Stats {get; private set;}
    public int Health {get; private set;}
    public int Mana {get; private set;}
    public int Coins {get; private set;}
    public bool Alive {get; set;}
    private List<IItem> Inventory {get; set;}
    private List<IMinion> Summons {get; set;}
    
    
    public Character(string name, int health, int mana, int damage, int armor, int speed)
    {
        Name = name;
        Stats = new Stats(health, mana, damage, armor, speed);
        Health = health;
        Mana = mana;
        Coins = 0;
        Alive = true;
        Inventory = new List<IItem>();
        Summons = new List<IMinion>();
    }

    public void Die()
    {
        Alive = false;
    }
    
    
    public int Attack()
    {
        int damage = Stats.BaseDamage;

        return damage;
    }
    
    
    public int Defend(int damage)
    {
        int actualDamage = damage - Stats.BaseArmor;

        if (actualDamage < 0)
        {
            actualDamage = 1;
        }
        
        return actualDamage;
    }
    
    
    public void Heal(int amount)
    {
        Health += amount;
        if (Health > Stats.MaxHealth)
        {
            Health = Stats.MaxHealth;
        }
        
        Console.WriteLine($"{Name} se ha curado, ahora tiene {Health} puntos de vida");
        
    }
    
    
    public void ReceiveDamage(int amount)
    {
        int armor = Stats.BaseArmor;
        
        int realDamage = amount - armor;
        if (realDamage <= 0)
        {
            realDamage = 1;
        }
        
        Health -= realDamage;
        
        if (Health <= 0)
        {
            Alive = false;
            Console.WriteLine($"¡{Name} sufre {realDamage} puntos de daño y muere!");
        }
        else
        {
            Console.WriteLine($"{Name} sufre {realDamage} puntos de daño, le quedan {Health}");
        }
    }
    
    
    public void EquipItem(IItem item)
    {
        Inventory.Add(item);
        item.Apply(this);
    }
    
    
    public void UnequipItem(IItem item)
    {
        Inventory.Add(item);
        item.Apply(this);
    }
    
    
    public void ShowInventory()
    {
        Console.WriteLine("Inventario:");
        foreach (var item in Inventory)
        {
            Console.WriteLine($"{item.GetType().Name}");
        }
    }
    
    
    public void ShowGeneralInfo()
    {
        Console.WriteLine($"Nombre: {Name}");
        Console.WriteLine($"HP: {Stats.MaxHealth}");
        ShowInventory();
        Console.WriteLine("");
    }
}