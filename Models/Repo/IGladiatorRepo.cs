using ReactApp.Models.Data;
using System.Collections.Generic;

namespace ReactApp.Models.Repo
{
    public interface IGladiatorRepo
    {

        Gladiator Create();

        List<Gladiator> Read();

        Gladiator Read(int id);

        Gladiator Update(Gladiator aGladiator);

        bool Delete(int id);
    }
}
