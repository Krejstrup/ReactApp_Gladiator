using ReactApp.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactApp.Models.ViewModels
{
    public class WeaponViewModel
    {

        public string Type { get; set; }    // Don't know yet. Melee 1 hand/2 hand/edge/bash, bow, pole...?

        public string Name { get; set; }    // special name if special weapon.

        public int Cost { get; set; }       // Cost to buy/sell. 0.1 to repair. Adjusted for durability.

        public int CombatBonus { get; set; }   // No weapon gives -4 in bonus. Just a plain weapon gives 0.

        public int Durability { get; set; } // weapon breaks if 0%

    }
}
