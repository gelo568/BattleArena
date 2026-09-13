using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors.Characters
{
    public class sammer : Warrior, IHealCaster
    {
        public int healing  { get; set; }
        public sammer(int health, int attackPower, int speed, int healing, TeamType teamType)
            : base("sammer", health, attackPower, speed, WarriorType.Healer, teamType)
        {
            healing = healing;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "ito sau", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}:huh ano {target.Name}!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Asar  {Name}");
        }

        public void HealTeamMates(List<Warrior> teamMates)
        {
            foreach (var warrior in teamMates)
            {
                if (warrior.IsAlive && warrior.TeamType == TeamType)
                {
                    Console.WriteLine($"->{Name}: suntokin kita {warrior.Name}!");
                    warrior.ReceiveHealing(healing, this);
                }
                else
                    Console.WriteLine($"->{Name}: Sayang, patay na si {warrior.Name}. " +
                        $"suntokan nalang.");
            }
        }
    }
}