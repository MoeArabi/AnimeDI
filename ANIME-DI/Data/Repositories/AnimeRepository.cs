using ANIME_DI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ANIME_DI.Data.Repositories
{
    public class AnimeRepository : IAnimeRepository
    {
        public List<Anime> AnimeList = new();

        private readonly AppDBContext _context;

        private readonly DbSet<Anime> _dbSet;

        public AnimeRepository(AppDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<Anime>();
        }

        public async Task<List<Anime>> GetAllAnime() => await _dbSet.ToListAsync();

        public async Task<Anime> AddAnime(Anime anime)
        {
            var createdEntity = await _dbSet.AddAsync(anime);
            await _context.SaveChangesAsync();
            return createdEntity.Entity;
        }

        public async Task Delete(int id)
        {
            var animeToRemove = await _dbSet.FirstOrDefaultAsync<Anime>(a => a.Id == id);
            if (animeToRemove != null)
                 _dbSet.Remove(animeToRemove);
        }

        public async Task<Anime> GetAnimeById(int id) => await _dbSet.FirstOrDefaultAsync(a => a.Id == id);

        public async Task<Anime> UpdateAnime(Anime anime)
        {
            var updatedEntity = _dbSet.Update(anime);
            await _context.SaveChangesAsync();
            return updatedEntity.Entity;
        }
    }
}
