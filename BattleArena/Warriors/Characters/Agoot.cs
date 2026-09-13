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
    public class Agoot : Warrior, IHealCaster
    {
        public int HealingAmount { get; set; }
        public Agoot(int health, int attackPower, TeamType teamType, int healingAmount)
            : base("Agoot", health, attackPower, WarriorType.Magery, teamType)
        {
            HealingAmount = healingAmount;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Haplos", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Lasapin mo yung haplos ko {target.Name}!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Asar mama {Name}");
        }

        public void HealTeamMates(List<Warrior> teamMates)
        {
            foreach (var warrior in teamMates)
            {
                if (warrior.IsAlive && warrior.TeamType == TeamType)
                {
                    Console.WriteLine($"->{Name}: Hala, haplosin ko na lang si {warrior.Name}!");
                    warrior.ReceiveHealing(HealingAmount, this);
                }
                else
                    Console.WriteLine($"->{Name}: Sayang, patay na si {warrior.Name}. " +
                        $"Hindi ko na siya mahaplos.");
            }
        }
    }
}