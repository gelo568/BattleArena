using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Raymond : Warrior
    {
        public int DuraDamage { get; private set; }
        public Raymond(int health, int attackPower, int speed, int duraDamage, TeamType teamType)
            : base("Raymond", health, attackPower, speed, WarriorType.Marksman, teamType)
        {
            DuraDamage = duraDamage;
            attackPower += DuraDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Dura", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Duburaan kita bebe {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Need more babe!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Buhay pa ko babe {target.Name}");
        }
    }

}


