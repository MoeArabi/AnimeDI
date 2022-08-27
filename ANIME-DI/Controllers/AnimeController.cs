using ANIME_DI.Data.Repositories;
using ANIME_DI.Models;

using Microsoft.AspNetCore.Mvc;

namespace ANIME_DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        private readonly IAnimeRepository _animeRepository;
        public AnimeController(IAnimeRepository animeRepository)
        {
           _animeRepository = animeRepository;
        }

        // GET: api/<AnimeController>
        [HttpGet]
        public ActionResult<IEnumerable<Anime>> Get()
        {
            var Animes = _animeRepository.GetAllAnime();
            return Ok(Animes);
        }

        // GET api/<AnimeController>/5
        [HttpGet("{id}")]
        public Task<Anime> Get(int id)
        {
            return _animeRepository.GetAnimeById(id);
        }

        // POST api/<AnimeController>
        [HttpPost]
        public Task<Anime> Post(Anime anime)
        {
            return _animeRepository.AddAnime(anime);
        }

        // PUT api/<AnimeController>/5
        [HttpPut("{id}")]
        public Task<Anime> Put(Anime anime)
        {
            return _animeRepository.UpdateAnime(anime);
        }

        // DELETE api/<AnimeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _animeRepository.Delete(id);
        }
    }
}
