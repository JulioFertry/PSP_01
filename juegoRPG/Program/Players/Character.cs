namespace juegoRPG.Program.Players;
using Minions;
using Items;

public class Character
{
    public string Name {get; private set;}
    public Stats Stats {get; private set;}
    public int Health {get; private set;}
    private List<IItem> Inventory {get; set;}
    private Equipment Equipment {get; set;}
    public List<Minion> Summons {get; set;}
    
    
    public Character(string name, int health, int damage, int armor, int magic)
    {
        Name = name;
        Stats = new Stats(health, damage, armor, magic);
        Health = health;
        Inventory = new List<IItem>();
        Equipment = new Equipment();
        Summons = new List<Minion>();
    }
    
    
    public event Action<String>? OnDamaged;
    public event Action<String>? OnDeath;
    public event Action<String>? OnHeal;
    public event Action<String>? OnEquip;
    public event Action<String>? OnUnequip;

    
    public bool IsAlive()
    {
        if (Health <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    
    
    public int Attack()
    {
        Weapon? weapon = Equipment.Weapon;
        
        int damage = Stats.BaseDamage;

        foreach (Minion minion in Summons)
        {
            damage += minion.Attack();
        }
        
        if (weapon is not null)
        {
            damage += weapon.Apply();
        }

        return damage;
    }
    
    
    private int Defend()
    {
        Protection? protection = Equipment.Protection;
        
        int defense = Stats.BaseDamage;
        
        if (protection is not null)
        {
            defense += protection.Apply();
        }
        
        return defense;
    }
    
    
    public void Heal()
    {
        if (IsAlive())
        {
            Health += Stats.Magic;
            if (Health > Stats.MaxHealth)
            {
                Health = Stats.MaxHealth;
            }
        
            OnHeal?.Invoke($"{Name} se ha curado, vida actual: {Health}");
        }
        
    }
    
    
    public void ReceiveDamage(int amount)
    {
        int defense = Defend();
        int actualDamage = amount - defense;

        if (actualDamage <= 0)
        {
            actualDamage = 1;
        }
        
        Health -= actualDamage;
        
        OnDamaged?.Invoke($"{Name} ha sufrido {actualDamage} de daño");

        if (!IsAlive())
        {
            OnDeath?.Invoke($"{Name} ha muerto!");
        }
        
    }
    
    
    public void TakeItem(IItem item)
    {
        Inventory.Add(item);
        if (item is Protection)
        {
            Protection? itemProt = item as Protection;
            itemProt.SetOwner(this);
        }
        else if (item is Weapon)
        {
            Weapon? itemWeap = item as Weapon;
            itemWeap.SetOwner(this);
        }

    }
    
    
    public void EquipItem(IItem item)
    {
        if (Inventory.Contains(item))
        {
            
            if (item is Protection)
            {
                Protection? itemProt = item as Protection;
                Equipment.EquipProt(itemProt);
            }
            else
            {
                Weapon? itemWeap = item as Weapon;
                Equipment.EquipWeap(itemWeap);
            }
        
            OnEquip?.Invoke($"{Name} ha equipado {item.GetType().Name}");
        }
        
    }
    
    
    public void UnequipItem(IItem item)
    {
        if (item is Protection)
        {
            Equipment.DeleteProt();
        }
        else
        {
            Equipment.DeleteWeap();
        }
        
        OnUnequip?.Invoke($"{Name} ha desequipado {item.GetType().Name}");
    }
    
    
    public void ShowInventory()
    {
        Console.WriteLine("Inventario:");
        foreach (var item in Inventory)
        {
            Console.WriteLine($"{item.GetType().Name}");
        }
    }

    
    public void ShowSummons()
    {
        Console.WriteLine("Minions:");
        foreach (var minion in Summons)
        {
            Console.WriteLine($"{minion.GetType().Name}");
        }
    }
    
    
    public void ShowGeneralInfo()
    {
        Console.WriteLine($"Nombre: {Name}");
        Console.WriteLine($"HP: {Stats.MaxHealth}");
        ShowInventory();
        ShowSummons();
        Console.WriteLine("");
    }

}