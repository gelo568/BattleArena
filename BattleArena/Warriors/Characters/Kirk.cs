using BattleArena.Warriors.Characters;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Kirk : Warrior
    {
        private bool _hasCriticalChance;

        public int Shield { get; private set; }
        public Kirk(int health, int attackPower, int shield)
            : base("kirk", health, attackPower, WarriorType.Tank)
        {
            Shield = shield;
        }

        public override void Attack(Warrior target)
        {

            var dmginfo = new DamageInfo(AttackPower, "Sipa", _hasCriticalChance);
            TakeDamage(dmginfo);



            Console.WriteLine($"\t-> {Name}: Wala kang Takas Boi! {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"\t-> {target.Name}: Napinsala ako!");


            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: Aray kopo! {target.Name}");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Shield;
            var newDmginfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical);
            base.TakeDamage(newDmginfo);
        }

    }
}