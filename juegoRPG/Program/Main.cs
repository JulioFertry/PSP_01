namespace juegoRPG.Program;
using Players;
using Items;

class MainClass
{

    static string Fight(Character j1, Character j2)
    {
        while (j1.Alive && j2.Alive)
        {
            
            if (j1.Alive)
            {
                j1.Attack();
            }

            if (j2.Alive)
            {
                j2.Attack();
            }
        }

        if (j1.Alive)
        {
            return j1.Name;
        }
        else
        {
            return j2.Name;
        }
        
    }
    
    
    static void Main()
    {
        // Crea un jugador
        Character jugador1 = new Character("Pepe", 50, 100, 10, 10, 50);
        
        // Crea 2 objetos
        Weapon espada = new Sword();
        Protection escudo = new Shield();
        
        // Equipa los objetos al jugador
        jugador1.EquipItem(espada);
        jugador1.EquipItem(escudo);
        
        
        // Crea otro jugador
        Character jugador2 = new Character("Juan", 35, 50, 20, 5, 65);
        
        // Crea 2 objetos
        Weapon hacha = new Axe();
        Protection casco = new Helmet();
        
        // Equipa los objetos al jugador
        jugador2.EquipItem(hacha);
        jugador2.EquipItem(casco);
        
        
        // Muestra la información de los jugadores
        Console.WriteLine("");
        jugador1.ShowGeneralInfo();
        jugador2.ShowGeneralInfo();
        
        string winner = Fight(jugador1, jugador2);
        Console.WriteLine($"El ganador es {winner}");
        
    }

    
}