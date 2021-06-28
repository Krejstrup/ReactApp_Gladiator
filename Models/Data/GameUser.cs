using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace ReactApp.Models.Data
{
    public class GameUser : IdentityUser
    {

        public Player ThePlayer { get; set; }   // Create this player and set the object here.
    }
}
