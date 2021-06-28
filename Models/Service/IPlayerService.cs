using ReactApp.Models.Data;

namespace ReactApp.Models.Service
{
    interface IPlayerService
    {
        public Player Add(Player aPlayer);

        public Player Read(int id);

        public bool Update(Player aPlayer);

        public bool Delete(Player aPlayer);

    }
}
