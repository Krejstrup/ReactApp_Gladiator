using System.ComponentModel.DataAnnotations;

namespace ReactApp.Models.Data
{
    public class Weapon
    {

        [Key]
        public int Id { get; set; }
        public string Type { get; set; }    // Don't know yet. Melee 1 hand/2 hand/edge/bash, bow, pole...?
        public string Name { get; set; }    // special name if special weapon.
        public int Cost { get; set; }   // Cost to buy/sell. 0.1 to repair. Adjusted for durability.
        public int CombatBonus { get; set; }   // No weapon gives -4 in bonus. Just a plain weapon gives 0.
        public int Condition { get; set; } // weapon breaks if 0%

        public Weapon(string type, string name, int cost, int combatBonus)
        {
            Id = 0;
            Type = type;
            Name = name;
            Cost = cost;
            CombatBonus = combatBonus;
            Condition = 100;
        }
        public Weapon(int rnd)  // rnd has to be a random number to get a random weapon
        {
            Id = 0;
            CombatBonus = 0;
            Cost = 2;
            Condition = 100;
            Name = "";
            Type = "Short Sword";
        }

    }
}
