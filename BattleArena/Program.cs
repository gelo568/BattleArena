using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior Raymond = new Warrior();
            Raymond.Name = "Raymond";
            Raymond.Health = 100;
            Raymond.AttackPower = 30;


            Warrior Kirk = new Warrior();
            Kirk.Name = "Kirk";
            Kirk.Health = 200;
            Kirk.AttackPower = 15;


            Warrior Sammer = new Warrior();
            Sammer.Name = "Sammer";
            Sammer.Health = 150;
            Sammer  .AttackPower = 25;


            Console.WriteLine($"{Raymond.Name} has " +
                $"{Raymond.Health} health and {Raymond.AttackPower} attack power.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"{Kirk.Name} has" +
                $" {Kirk.Health} health and {Kirk.AttackPower} attack power.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"{Sammer.Name} has" +
                $" {Sammer.Health} health and {Sammer.AttackPower} attack power.");
            Console.WriteLine("---------------------------------");
            Console.ReadKey();
        }
    }
}