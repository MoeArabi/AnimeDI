namespace ANIME_DI.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MCName { get; set; }
        public int Seasons { get; set; }

        public Anime(int id, string name, string mcName, int seasons)
        {
            Id = id;
            Name = name;
            MCName = mcName;
            Seasons = seasons;
        }

        public Anime Update(string name, string mcName, int seasons)
        {
            if (seasons > 500)
                throw new ArgumentOutOfRangeException(nameof(seasons));
            (Name, MCName, Seasons) = (name, mcName, seasons);
            return this;
        }
    }
}


