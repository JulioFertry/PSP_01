using juegoRPG.Program.Players;

namespace juegoRPG.Program.Fighting;

public class Battle
{
    private Character _player1;
    private Character _player2;
    private Boolean _isOngoing;

    public Battle(Character player1, Character player2)
    {
        _player1 = player1;
        _player2 = player2;
        _isOngoing = false;
        SubscribeToEvents();
    }
    
    
    private void SubscribeToEvents()
    {
        _player1.OnDamaged += (message) => Console.WriteLine(message);
        _player1.OnDeath += (message) => Console.WriteLine(message);
        _player1.OnHeal += (message) => Console.WriteLine(message);
        _player1.OnEquip += (message) => Console.WriteLine(message);
        _player1.OnUnequip += (message) => Console.WriteLine(message);

        
        _player2.OnDamaged += (message) => Console.WriteLine(message);
        _player2.OnDeath += (message) => Console.WriteLine(message);
        _player2.OnHeal += (message) => Console.WriteLine(message);
        _player2.OnEquip += (message) => Console.WriteLine(message);
        _player2.OnUnequip += (message) => Console.WriteLine(message);
    }


    public void StartBattle()
    {
        _isOngoing = true;

        while (_isOngoing)
        {
            Turn(_player1, _player2);
            if (!_player2.IsAlive())
            {
                _isOngoing = false;
            }
            
            Turn(_player2, _player1);
            if (!_player1.IsAlive())
            {
                _isOngoing = false;
            }
        }
        
    }


    public void Turn(Character attacker, Character defender)
    {
        if (attacker.IsAlive() && defender.IsAlive())
        {
            int totalDamage = attacker.Attack();
        
            defender.ReceiveDamage(totalDamage);
        
            defender.Heal();
        }
    }
    
}