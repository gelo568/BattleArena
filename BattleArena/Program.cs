using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using BattleArena.Warriors.Characters;
using System;

namespace BattleArena.Warriors
{
    public struct DamageInfo
    {
        public int TotalAmountDamage { get; private set; }
        public int ActualAmountDamage { get; private set; }
        public string AttackType { get; private set; }
        public bool IsCritical { get; private set; }
        public Warrior From { get; private set; }
        public int NewActualDamage { get; }

        public DamageInfo(int totalAmountDamage, int actualAmountDamage, string attackType, bool isCritical, Warrior from)
        {
            TotalAmountDamage = totalAmountDamage;
            ActualAmountDamage = actualAmountDamage;
            AttackType = attackType;
            IsCritical = isCritical;
            From = from;
        }

        public DamageInfo(int attackPower, string v, bool hasCriticalChance, Kirk kirk) : this()
        {
        }

        public DamageInfo(int attackPower, string v, bool hasCriticalChance, Agoot agoot) : this()
        {
        }

        public DamageInfo(int attackPower, string v, bool hasCriticalChance, Cods cods) : this()
        {
        }

        public DamageInfo(int attackPower, string v, bool hasCriticalChance, Kir.Kirk kirk) : this()
        {
        }

        public DamageInfo(int newActualDamage, string attackType, bool isCritical, Warrior from) : this()
        {
            NewActualDamage = newActualDamage;
            AttackType = attackType;
            IsCritical = isCritical;
            From = from;
        }
    }

    public abstract class Warrior : IHealable
    {
        private bool _isAlive;
        private bool _hasCriticalChance;

        protected DamageInfo _damageTaken;
        protected Random _random = new Random();

        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }

        public WarriorType WarriorType { get; private set; }
        public TeamType TeamType { get; private set; }


        public bool IsAlive
        {
            get
            {
                _isAlive = Health > 0;
                return _isAlive;
            }
            private set { _isAlive = value; }
        }

        public bool HasCriticalChance
        {
            get
            {
                var chance = _random.Next(0, 100);
                _hasCriticalChance = chance < 30;
                return _hasCriticalChance;
            }
            private set { _hasCriticalChance = value; }
        }

        IHealCaster IHealable.TeamType => throw new NotImplementedException();

        public Warrior(string name, int health, int attackPower, WarriorType warriorType, TeamType teamType)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            WarriorType = warriorType;
            TeamType = teamType;
        }

        protected virtual void TakeDamage(DamageInfo damage)
        {
            _damageTaken = damage;
            Health -= damage.TotalAmountDamage;
            if (Health < 0) Health = 0;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"\t---== {Name} ==---");

            if (_damageTaken.IsCritical)
                Console.WriteLine($"\t---- Critical Hit ----");

            Console.WriteLine($"\t[*] Health: {Health}");
            Console.WriteLine($"\t[*] Attack Power: {AttackPower}");
            Console.WriteLine($"\t[*] Damage Taken: {_damageTaken.TotalAmountDamage}");
        }

        public abstract void Attack(Warrior target);

        public void ReceiveHealing(int amount, Warrior healer)
        {
            if (healer.TeamType == TeamType)
            {
                Health += amount;
                Console.WriteLine($"->{Name}: Received healing from {healer.Name}! Health is now {Health}");
            }
        }
    }
}