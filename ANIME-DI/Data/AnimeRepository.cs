using ANIME_DI.Model;

namespace ANIME_DI.Data
{
    public class AnimeRepository : IAnimeRepository
    {
        public static List<Anime> Animes = new List<Anime>
    {
                new Anime {Id = 1, Name="OnePiece",MCName="Luffy",seasons=20 },
                new Anime {Id = 2, Name="Naruto Shippuden",MCName="Naruto",seasons=15 }

    };
        public List<Anime> GetallAnimes()
        {
            return Animes;
        }
        public List<Anime> Addanime(Anime anime)
        {
            Animes.Add(anime);


            return Animes;
        }
        public List<Anime> Delete(int id)
        {
            var anime = Animes.Find(H => H.Id == id);
            if (anime == null)
                // return BadRequest("Anime not found.");
                Animes.Remove(anime);
            return Animes;
        }

    }
}
