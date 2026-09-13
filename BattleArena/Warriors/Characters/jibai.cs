using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class jibai : Warrior
    {
        public int MouthDamage { get; private set; }
        public jibai(int health, int attackPower, int speed, int mouthDamage, TeamType teamType)
            : base("jibai", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            MouthDamage = mouthDamage;
            attackPower += MouthDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "duduran", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: kiss kita {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Aray ko po!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: HAHAHAH patay {target.Name}");
        }
    }

}