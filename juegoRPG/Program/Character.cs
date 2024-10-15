namespace juegoRPG.Program;
using Minions;
using Items;
using Perks;

public class Character
{
    public string Name {get; private set;}
    public int MaxHitPoints {get; set;}
    public int HitPoints {get; set;}
    public bool Alive {get; set;}
    public int BaseDamage {get; set;}
    public int BaseArmor {get; set;}
    private List<IItem> Inventory {get; set;}
    private List<IMinion> Summons {get; set;}
    private List<IPerk> Perks {get; set;}
    
    
    public Character(string name, int maxHitPoints, int baseDamage, int baseArmor)
    {
        Name = name;
        MaxHitPoints = maxHitPoints;
        HitPoints = maxHitPoints;
        Alive = true;
        BaseDamage = baseDamage;
        BaseArmor = baseArmor;
        Inventory = new List<IItem>();
        Summons = new List<IMinion>();
        Perks = new List<IPerk>();
    }
    
    
    public void Attack(Character target)
    {
        int damage = BaseDamage;
        
        Console.WriteLine($"{Name} ataca a {target.Name}");
        target.ReceiveDamage(damage);
    }
    
    
    public void Defend()
    {
        BaseArmor += 2;
        BaseDamage += 1;
        Console.WriteLine($"{Name} se defiende, su adefensa sube 2 puntos y su ataque sube 1 punto");
    }
    
    
    public void Sharpen()
    {
        BaseDamage += 3;
        BaseArmor -= 1;
        Console.WriteLine($"{Name} afila su arma ganando 3 puntos de ataque y perdiendo 1 punto de defensa");
    }
    
    
    public void Heal(int amount)
    {
        HitPoints += amount;
        if (HitPoints > MaxHitPoints)
        {
            HitPoints = MaxHitPoints;
        }
        
        Console.WriteLine($"{Name} se ha curado, ahora tiene {HitPoints} puntos de vida");
        
    }
    
    
    public void ReceiveDamage(int amount)
    {
        int armor = BaseArmor;
        
        int realDamage = amount - armor;
        if (realDamage <= 0)
        {
            realDamage = 1;
        }
        
        HitPoints -= realDamage;
        
        if (HitPoints <= 0)
        {
            Alive = false;
            Console.WriteLine($"¡{Name} sufre {realDamage} puntos de daño y muere!");
        }
        else
        {
            Console.WriteLine($"{Name} sufre {realDamage} puntos de daño, le quedan {HitPoints}");
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
        Console.WriteLine($"HP: {MaxHitPoints}");
        ShowInventory();
        Console.WriteLine("");
    }
}