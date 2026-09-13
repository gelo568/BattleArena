using BattleArena.Warriors;

namespace BattleArena.Combat
{
    public interface IDamageInfo
    {
        int ActualAmountDamage { get; }
       
        string AttackType { get; }
        
        Warrior From { get; }
       
        bool IsCritical { get; }
       
        int TotalAmountDamage { get; }
        
    }
}