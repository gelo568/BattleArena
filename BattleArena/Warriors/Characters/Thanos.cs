using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Thanos  : Warrior, IDefender
    {
        public int InfinityGauntlet { get; private set; }

        public Thanos(int health, int attackPower, int speed, int infinityGauntlet, TeamType teamType)
            : base("Thanos  ", health, attackPower, speed, WarriorType.Tank, teamType)
        {
            InfinityGauntlet = infinityGauntlet;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "haplusin mo", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: dumogin moko {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: yakap hanggang mag violet {Name}!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: ugh {Name}");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - InfinityGauntlet;

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