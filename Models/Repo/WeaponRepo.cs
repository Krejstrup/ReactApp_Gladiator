using ReactApp.Models.Data;
using System;
using System.Collections.Generic;

namespace ReactApp.Models.Repo
{
    public class WeaponRepo : IWeaponRepo
    {


        Weapon IWeaponRepo.Create()
        {
            throw new NotImplementedException();
        }

        List<Weapon> IWeaponRepo.Read()
        {
            throw new NotImplementedException();
        }

        Weapon IWeaponRepo.Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Weapon aWeapon)
        {
            throw new NotImplementedException();
        }

        bool IWeaponRepo.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
