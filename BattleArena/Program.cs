using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int round = 1;
            Warrior Raymond = new Warrior("Raymond", 100, 30, "Dinuraan");
            Warrior Kirk = new Warrior("Kirk", 200, 15, "Dinaganan");
            Warrior Sammer = new Warrior("Sammer", 180, 25, "Ice Shard");

            Raymond.DisplayStats();
            Kirk.DisplayStats();
            Sammer.DisplayStats();

            while (Raymond.IsAlive && Kirk.IsAlive && Sammer.IsAlive)
            {
                Console.WriteLine($"------Round {round}------");
                Raymond.Attack(Kirk);
                Kirk.Attack(Sammer);
                Sammer.Attack(Raymond);
                Console.WriteLine("----------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}