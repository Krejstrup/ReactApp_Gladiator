using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReactApp.Models.Data
{
    public class Player
    {
        /// <summary>
        /// The unique Id of this Player.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// This Players first name.
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }


        /// <summary>
        /// This Players total number of XP for all Gladialtors.
        /// </summary>
        public int Xp { get; set; }

        public int GameScore { get; set; }  // What is this to be used for??


        /// <summary>
        /// The type of in game money.
        /// </summary>
        public int Caps { get; set; }

        /// <summary>
        /// This Players Gladiators. This is a Id to an One-to-Many database relation.
        /// </summary>
        public List<Gladiator> Gladiators { get; set; }
    }
}
