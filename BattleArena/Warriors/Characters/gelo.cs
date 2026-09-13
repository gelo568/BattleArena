using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class gelo : Warrior, ISpellCaster
    {
        public int Sword { get; private set; }

        public gelo(int health, int attackPower, int speed, int sword, TeamType teamType)
            : base("gelo", health, attackPower, speed, WarriorType.Assassin, teamType)
        {
            Sword = sword;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "wattata", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: mama mo {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: hawakan moto {Name}!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: tumitigas na {Name}");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Sword;

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