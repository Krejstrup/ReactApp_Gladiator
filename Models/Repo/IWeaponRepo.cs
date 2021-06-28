using ReactApp.Models.Data;
using System.Collections.Generic;

namespace ReactApp.Models.Repo
{
    interface IWeaponRepo
    {
        Weapon Create();

        List<Weapon> Read();

        Weapon Read(int id);

        bool Update(Weapon aWeapon);

        bool Delete(int id);
    }
}
