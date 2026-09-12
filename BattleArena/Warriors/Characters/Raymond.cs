using BattleArena.Warriors.Characters;
using System;
using System.Threading;

namespace BattleArena.Warriors
{
    public class Raymond : Warrior
    {
        private bool _hasCriticalChance;

        public int SibatDamage { get; private set; }
        public Raymond(int health, int attackPower, int arrowDamage)
            : base("Raymond", health, attackPower, WarriorType.Marksman)
        {
            SibatDamage = arrowDamage;
            attackPower += SibatDamage;
        }


        public override void Attack(Warrior target)
        {

            var dmginfo = new DamageInfo(AttackPower, "Sibat", _hasCriticalChance);
            TakeDamage(dmginfo);


            Thread.Sleep(1000);
            Console.WriteLine($"\t-> {Name}: Ano ka Boi! {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"\t-> {target.Name}: Takas kapa!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: Punit ako! {target.Name}");

        }
    }
}
