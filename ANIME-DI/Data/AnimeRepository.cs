using ANIME_DI.Models;

namespace ANIME_DI.Data
{
    public class AnimeRepository : IAnimeRepository
    {
        public List<Anime> AnimeList = new();

        public List<Anime> GetAllAnime()
        {
            return AnimeList;
        }
        public Anime AddAnime(string name, string mcName, int seasons)
        {
            var newId = AnimeList.Max(x => x.Id) + 1;
            Anime anime = new(newId, name, mcName, seasons);
            AnimeList.Add(anime);
            return anime;
        }
        public void Delete(int id)
        {
            var anime = AnimeList.FirstOrDefault(a => a.Id == id);
            if (anime != null)
                AnimeList.Remove(anime);
        }

        public Anime GetAnimeById(int id)
        {
            return AnimeList.FirstOrDefault(a => a.Id == id);
        }

        public Anime UpdateAnime(int id, string name, string mcName, int seasons)
        {
            var anime = AnimeList.FirstOrDefault(a => a.Id == id);
            var updatedAnime = anime.Update(name, mcName, seasons);
            return updatedAnime;
        }
    }
}
