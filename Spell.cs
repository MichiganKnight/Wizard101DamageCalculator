namespace Wizard101DamageCalculator
{
    public enum SpellType
    {
        Attack,
        Heal,
        Shield,
        Charm,
        Ward
    }

    public enum School
    {
        Fire,
        Ice,
        Storm,
        Myth,
        Life,
        Death,
        Balance,
        Sun,
        Moon,
        Star,
        Shadow
    }

    public class Spell
    {
        public string SpellName { get; set; } = "";
        public int Damage { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int FirstDamage { get; set; }
        public int OverTimeDamage { get; set; }
        public int NumberOfPips { get; set; }
        public SpellType SpellType { get; set; }
        public School School { get; set; }

        public static SingleTypeSpell[] GetAllSingleSpells()
        {
            SingleTypeSpell[] spells =
            {
                new SingleTypeSpell("Naphtha Scarab", 100, SpellType.Attack, School.Fire),
            };

            return spells;
        }

        public static MinMaxTypeSpell[] GetAllMinMaxSpells()
        {
            MinMaxTypeSpell[] spells =
            {
                new MinMaxTypeSpell("Fire Cat", 80, 120, SpellType.Attack, School.Fire),
            };

            return spells;
        }

        public static FirstAndOverTimeTypeSpell[] GetAllFirstAndOverTimeSpells()
        {
            FirstAndOverTimeTypeSpell[] spells =
            {
                new FirstAndOverTimeTypeSpell("Fire Elf", 100, 210, SpellType.Attack, School.Fire),
            };

            return spells;
        }

        public static Spell[] GetAllSpells()
        {
            Spell currentSingleSpell = new();
            Spell currentMinMaxSpell = new();

            SingleTypeSpell[] singleTypeSpells = GetAllSingleSpells();

            foreach (SingleTypeSpell singleTypeSpell in singleTypeSpells)
            {
                currentSingleSpell = singleTypeSpell;
            }

            MinMaxTypeSpell[] minMaxTypeSpells = GetAllMinMaxSpells();

            foreach (MinMaxTypeSpell minMaxTypeSpell in minMaxTypeSpells)
            {
                currentMinMaxSpell = minMaxTypeSpell;
            }

            Spell[] spells =
            {
                currentSingleSpell,
                currentMinMaxSpell
            };

            return spells;
        }

        /// <summary>
        /// Get All Spell Names
        /// </summary>
        /// <param name="spells">Array Of Every Spell</param>
        /// <returns>Array Of Spell Names</returns>
        public static string[] GetAllSpellNames(Spell[] spells)
        {
            string name = "";

            foreach (Spell spell in spells)
            {
                name = spell.SpellName;
            }

            string[] names =
            {
                name
            };

            return names;
        }

        /// <summary>
        /// Get Currently Selected Spell's School
        /// </summary>
        /// <param name="spell">Current Spell</param>
        /// <returns><see cref="School"/></returns>
        public static School GetCurrentSpellSchool(Spell spell)
        {
            School school = spell.School;

            return school;
        }
    }

    public class SingleTypeSpell : Spell
    {
        /// <summary>
        /// Define a <see cref="SingleDamageSpell"/> with a single attack damage
        /// </summary>
        /// <param name="spellName">Spell Name</param>
        /// <param name="damage">Spell Damage</param>
        public SingleTypeSpell(string spellName, int damage, SpellType spellType, School school)
        {
            SpellName = spellName;
            Damage = damage;
            SpellType = spellType;
            School = school;
        }
    }

    public class MinMaxTypeSpell : Spell
    {
        /// <summary>
        /// Define a <see cref="MinMaxDamageSpell"/> with a minimum and maximum damage
        /// </summary>
        /// <param name="spellName">Spell Name</param>
        /// <param name="minDamage">Spell Minimum Damage</param>
        /// <param name="maxDamage">Spell Maximum Damage</param>
        public MinMaxTypeSpell(string spellName, int minDamage, int maxDamage, SpellType spellType, School school)
        {
            SpellName = spellName;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            SpellType = spellType;
            School = school;
        }
    }

    public class FirstAndOverTimeTypeSpell : Spell
    {
        /// <summary>
        /// Define a <see cref="FirstAndOverTimeDamageSpell"/> with a first hit and damage over time
        /// </summary>
        /// <param name="spellName">Spell Name</param>
        /// <param name="firstDamage">Spell First Damage</param>
        /// <param name="overTimeDamage">Spell Over Time Damage</param>
        public FirstAndOverTimeTypeSpell(string spellName, int firstDamage, int overTimeDamage, SpellType spellType, School school)
        {
            SpellName = spellName;
            FirstDamage = firstDamage;
            OverTimeDamage = overTimeDamage;
            SpellType = spellType;
            School = school;
        }
    }

    public class PerPipTypeSpell : Spell
    {
        /// <summary>
        /// Define a <see cref="DamagePerPipSpell"/> with a damage and number of pips
        /// </summary>
        /// <param name="spellName">Spell Name</param>
        /// <param name="damage">Spell Damage</param>
        /// <param name="numberOfPips">Number Of Pips</param>
        public PerPipTypeSpell(string spellName, int damage, int numberOfPips, SpellType spellType, School school)
        {
            SpellName = spellName;
            Damage = damage;
            NumberOfPips = numberOfPips;
            NumberOfPips = numberOfPips;
            SpellType = spellType;
            School = school;
        }
    }
}
