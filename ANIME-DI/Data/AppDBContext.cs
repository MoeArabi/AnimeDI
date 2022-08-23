using Microsoft.EntityFrameworkCore;
using ANIME_DI.Models;
namespace ANIME_DI.Data
{
    public class AppDBContext :DbContext
    {
        public DbSet<Anime> Animes { get; set; }
       // public DbSet<MCharacter> MCharacters { get; set; }

        public string DbPath { get; private set; }


        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "Anime.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlite($"Data Source={DbPath}");


    }
}

