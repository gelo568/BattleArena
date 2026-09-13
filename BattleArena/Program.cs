using BattleArena.Enums;
using BattleArena.Warriors.Characters;
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
            var Raymond = new Cods(100, 30, 25, 10, TeamType.A);
            var Kirk = new Kirk(200, 15, 10, 30, TeamType.B);
            var Agoot = new Agoot(150, 20, 15, 10, TeamType.A);

            BattleArena.AddWarrior(Raymond);
            BattleArena.AddWarrior(Kirk);
            BattleArena.AddWarrior(Agoot);

            BattleArena.StartBattle();
        }
    }
}