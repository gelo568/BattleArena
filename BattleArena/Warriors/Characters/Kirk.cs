using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Kir
{
    public class Kirk : Warrior, IDefender
    {
        public int Shield { get; private set; }

        public Kirk(int health, int attackPower, int shield, TeamType teamType)
            : base("Kirk", health, attackPower, WarriorType.Tank, teamType)
        {
            Shield = shield;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Ngalngal", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Lasapin mo yakap ko {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Hug me tight {Name}!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Kulang pa sa hug bebe {Name}");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Shield;

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
    }

}