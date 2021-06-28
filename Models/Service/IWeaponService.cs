using ReactApp.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactApp.Models.Service
{
    interface IWeaponService
    {

        public Weapon GetRandom();


        public bool Update(Weapon aWapon);   // repair the weapon to 100% Condition. Return the cost.

        public bool Destroy(Weapon aWeapon);

    }
}
