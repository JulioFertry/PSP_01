namespace juegoRPG.Program;
using Players;
using Items;
using Fighting;

class MainClass
{
    static void Main()
    {
        Character player1 = new Character("Juana de Arco", 100, 15, 8, 3);
        Character player2 = new Character("William Wallace", 100, 10, 4, 8);
        
        Battle battle = new Battle(player1, player2);

        Weapon weapon1 = new Sword();
        Weapon weapon2 = new MagicStaff();
    
        Protection protection1 = new Helmet(); 
        Protection protection2 = new Shield();
        
        player1.TakeItem(weapon1);
        player1.TakeItem(protection1);
        player1.EquipItem(weapon1);
        player1.EquipItem(protection1);
        
        player2.TakeItem(weapon2);
        player2.TakeItem(protection2);
        player2.EquipItem(weapon2);
        player2.EquipItem(protection2);
        
        battle.StartBattle();
    }
    
}