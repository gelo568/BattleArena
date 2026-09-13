using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class luna : Warrior
    {
        public int Mage { get; private set; }
        public luna(int health, int attackPower, int speed, int Mage, TeamType teamType)
            : base("luna", health, attackPower, speed, WarriorType.Marksman, teamType)
        {
            Mage = Mage;
            attackPower += Mage;
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


