using ANIME_DI.Models;

namespace ANIME_DI.Data
{
    public interface IAnimeRepository
    {
        List<Anime> GetAllAnime();
        Anime GetAnimeById(int id);
        Anime AddAnime(string name, string mcName, int seasons);
        Anime UpdateAnime(int id, string name, string mcName, int seasons);
        void Delete(int id);
    }
}