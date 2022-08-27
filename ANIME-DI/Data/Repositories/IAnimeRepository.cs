using ANIME_DI.Models;

namespace ANIME_DI.Data.Repositories
{
    public interface IAnimeRepository
    {
        Task<List<Anime>> GetAllAnime();
        Task<Anime> GetAnimeById(int id);
        Task<Anime> AddAnime(Anime anime);
        Task<Anime> UpdateAnime(Anime anime);
        Task Delete(int id);
    }
}