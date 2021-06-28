using ReactApp.Models.Data;

namespace ReactApp.Models.Service
{
    public class NpcGladiator : Gladiator
    {
        //public int Id { get; set; }

        //public string Name { get; set; }

        ///// <summary>
        ///// This Gladiators experience points.
        ///// </summary>
        //public int Xp { get; set; }

        ///// <summary>
        ///// THe Gladiators maximum HP
        ///// </summary>
        //public int MaxHP { get; set; }

        ///// <summary>
        ///// The Gladiators current HP, dead if below one
        ///// </summary>
        //public int HP { get; set; }

        ///// <summary>
        ///// The Combat value of this Gladialtor
        ///// </summary>
        //public int CombatValue { get; set; }

        ///// <summary>
        ///// All the weapons the Gladiator has and can use
        ///// </summary>
        //public List<Weapon> Weapons { get; set; }

        ///// <summary>
        ///// The number of caps a gladiator has. Loot value for opponent!
        ///// </summary>
        //public int Caps { get; set; }

        //public int CapsValue { get; set; }



        public NpcGladiator()
        {
            Name = "Roland";
            CombatValue = Dice.ThrowDie(1, 10) + 10;
            MaxHP = Dice.ThrowDie(1, 10) + 20;
            HP = MaxHP;
            Xp = 1; // Value for Xp bonus. XP is calculated by difference of CV: Player - NPC, allways lowest 1xp.
            Weapons = null; // create and make a list of Weapons (max 2) Main and dagger.
            Caps = Dice.ThrowDie(1, 6);

        }


    }
}
