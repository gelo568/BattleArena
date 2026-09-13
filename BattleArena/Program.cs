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
            var Thanos = new Thanos(250, 25, 20, 40, TeamType.B);
            var eloit = new eloit(120, 10, 30, 20, TeamType.A);
            var jibai = new jibai(180, 20, 15, 25, TeamType.B);
            var luna = new luna(200, 25, 20, 30, TeamType.A);
            var kairi = new kairi(150, 25, 20, 35, TeamType.B);
            var sammer = new sammer(200, 20, 15, 25, TeamType.A);
            var gelo = new gelo(180, 15, 10, 20, TeamType.B);
            var Cods = new gelo(180, 15, 10, 20, TeamType.B);


            BattleArena.AddWarrior(Raymond);
            BattleArena.AddWarrior(Kirk);
            BattleArena.AddWarrior(Agoot);
            BattleArena.AddWarrior(Thanos);
            BattleArena.AddWarrior(eloit);
            BattleArena.AddWarrior(jibai);
            BattleArena.AddWarrior(luna);
            BattleArena.AddWarrior(kairi);
            BattleArena.AddWarrior(sammer);
            BattleArena.AddWarrior(gelo);
            BattleArena.AddWarrior(Cods);







            BattleArena.StartBattle();
        }
    }
}