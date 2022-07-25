using ANIME_DI.Model;

namespace ANIME_DI.Data
{
    public interface IAnimeRepository
    {
        List<Anime> Addanime(Anime anime);
        List<Anime> Delete(int id);
        List<Anime> GetallAnimes();
    }
}