using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    internal class Warrior
    {
        private int _isAlive;
        public string Name { get; private set; }
        public string SpecialAttackName { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }
        public bool IsAlive { get; private set; }

        public Warrior(string name, int health, int attackPower, string specialAttackName)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            SpecialAttackName = specialAttackName;
        }
        private void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }

        public void Attack(Warrior target)
        {
            TakeDamage(target.AttackPower);
            Console.WriteLine($"{SpecialAttackName} ni {Name} si {target.Name}");
            Console.WriteLine($"{target.Name} takes {AttackPower} damage!");
            Console.WriteLine($"{target.Name} has {target.Health} health remaining.");
            Console.WriteLine("-----------------------------------------------------\n");

        }

        public void DisplayStats()
        {
            Console.WriteLine($"---=={Name}---==");
            Console.WriteLine($"\t[*] Health: {Health}");
            Console.WriteLine($"\t[*] Attack Power: {AttackPower}");
            Console.WriteLine($"\t[*] Special Attack: {SpecialAttackName}");
            Console.WriteLine("------------------------------------------------------\n");
        }
    }
}