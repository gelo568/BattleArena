using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    internal class Warrior
    {

        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }
        public Warrior(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }
    }
}