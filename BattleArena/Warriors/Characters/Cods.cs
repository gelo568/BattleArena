using BattleArena.Warriors.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BattleArena.Warriors
{
    public class Cods : Warrior
    {
        private readonly bool _hasCriticalChance;

        public int PunchDamage { get; private set; }
        public Cods(int health, int attackPower, int punchDamage)
            : base("Cods", health, attackPower, WarriorType.Fighter)
        {
            PunchDamage = punchDamage;
            attackPower += punchDamage;
        }


        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower + PunchDamage;

            var dmginfo = new DamageInfo(AttackPower, "Sapak", _hasCriticalChance);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t-> {Name}: Ano na Boi kapa! {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"\t-> {target.Name}: Napinsala ako!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: Patay ka ngayon! {target.Name}");

        }

    }
}
