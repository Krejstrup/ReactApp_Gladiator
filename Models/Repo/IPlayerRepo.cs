using ReactApp.Models.Data;
using System.Collections.Generic;

namespace ReactApp.Models.Repo
{
    public interface IPlayerRepo
    {

        Player Create();
        List<Player> Read();

        Player Read(int id);

        Player Update(Player aPlayer);

        bool Delete(int id);
    }
}
