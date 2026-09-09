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
            var Raymond = new Marksman("Raymond", 100, 30);
            var Kirk = new Fighter("Kirk", 200, 15);
            var Sammer = new Tank("Sammer", 150, 30);

            Raymond.DisplayStats();
            Kirk.DisplayStats();
            Sammer.DisplayStats();

            while (Raymond.IsAlive && Kirk.IsAlive && Sammer.IsAlive)
            {

                Raymond.Attack(Kirk);
                Console.WriteLine("----------------------------------------------");
                Sammer.Attack(Raymond);
                Console.WriteLine("----------------------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}