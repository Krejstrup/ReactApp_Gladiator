using ReactApp.Models.Service;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReactApp.Models.Data
{
    public class Gladiator
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        /// <summary>
        /// This Gladiators experience points.
        /// </summary>
        public int Xp { get; set; }

        /// <summary>
        /// THe Gladiators maximum HP
        /// </summary>
        public int MaxHP { get; set; }

        /// <summary>
        /// The Gladiators current HP, dead if below one
        /// </summary>
        public int HP { get; set; }

        /// <summary>
        /// The Combat value of this Gladialtor
        /// </summary>
        public int CombatValue { get; set; }

        /// <summary>
        /// All the weapons the Gladiator has and can use
        /// </summary>
        public List<Weapon> Weapons { get; set; }

        /// <summary>
        /// The number of caps a gladiator has. Loot value for opponent!
        /// </summary>
        public int Caps { get; set; }



        /// <summary>
        /// Gladiator short Constructor
        /// </summary>
        public Gladiator()
        {
            Name = "Harald";
            Xp = 1;
            MaxHP = Dice.ThrowDie(1, 10) + 20;
            HP = MaxHP;
            CombatValue = 5;
            Weapons = null;
            Caps = 0;
        }

        /// <summary>
        /// Gladiator extended Constructor
        /// </summary>
        /// <param name="name">The Name.</param>
        /// <param name="maxHP">Maximum hitpoints for the gladiator.</param>
        /// <param name="combatValue">This Gladiators Combat Value.</param>
        public Gladiator(string name, int maxHP, int combatValue)
        {
            Name = name;
            Xp = 1;
            MaxHP = maxHP;  //Dice.ThrowDie(1, 10) + 10
            HP = maxHP;     //Dice.ThrowDie(1, 10) + 20
            CombatValue = combatValue;
            Weapons = null;
            Caps = 0;
        }
    }
}
