using ANIME_DI.Data;
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
        public Anime Get(int id)
        {
            return _animeRepository.GetAnimeById(id);
        }

        // POST api/<AnimeController>
        [HttpPost]
        public Anime Post(string name, string mcName, int seasons)
        {
            return _animeRepository.AddAnime(name, mcName, seasons);
        }

        // PUT api/<AnimeController>/5
        [HttpPut("{id}")]
        public Anime Put(int id, string name, string mcName, int seasons)
        {
            return _animeRepository.UpdateAnime(id, name, mcName, seasons);
        }

        // DELETE api/<AnimeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _animeRepository.Delete(id);
        }
    }
}
