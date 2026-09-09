using System;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Tank : Warrior
    {
        public int Shield { get; private set; }
        public Tank(string name, int health, int attackPower, int shield)
            : base(name, health, attackPower)
        {
            Shield = shield;
            attackPower += shield;
        }

        public Tank(string name, int health, int attackPower, string specialAttackName) : base(name, health, attackPower)
        {
        }

        public Tank(string name, int health, int attackPower) : base(name, health, attackPower)
        {
        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower + Shield;
            TakeDamage(totalDamage);
            Console.WriteLine($"\t-> {Name}: Wala kang Takas Boi! {target.Name}!");
            Thread.Sleep(1000);

            Console.WriteLine($"\t-> {target.Name}: Napinsala ako!");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: Aray kopo! {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t------ {target.Name} --------");
            Console.WriteLine($"\t  *Damage Taken: {totalDamage} *");
            Console.WriteLine($"\t  *Remaining Health: {target.Health} *");



        }
    }
}
