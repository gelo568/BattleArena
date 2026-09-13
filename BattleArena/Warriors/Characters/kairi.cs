using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class kairi : Warrior, ISpellCaster
    {
        public int Shadow { get; private set; }

        public kairi(int health, int attackPower, int speed, int shadow, TeamType teamType)
            : base("kairi", health, attackPower, speed, WarriorType.Assassin, teamType)
        {
            Shadow = shadow;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "shingshing", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: ulol {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: kumar kumar {Name}!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: wala kang takas boi {Name}");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Shadow;

            var blockChance = _random.Next(0, 100);
            var isBlocked = blockChance < 50;
            _damageTaken = damage;

            if (isBlocked) Block();
            else
            {
                var newDmginfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical, damage.From);
                base.TakeDamage(newDmginfo);
            }
        }
        public void Block()
        {
            Console.WriteLine($"Hahaha! Blocked {_damageTaken.TotalAmountDamage} damage from {_damageTaken.From.Name}! ");
        }

        public void CastSpell(Warrior target)
        {
            throw new NotImplementedException();
        }
    }

}