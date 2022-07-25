using ANIME_DI.Data;
using ANIME_DI.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ANIME_DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        private readonly IAnimeRepository _repository1;
        public AnimeController(IAnimeRepository repository)
        {
           _repository1 = repository;
    }
        //AnimeRepository repository = new AnimeRepository();
        

        // GET: api/<AnimeController>
        [HttpGet]
        public ActionResult<IEnumerable<Anime>> Get()
        {
            var Animes = _repository1.GetallAnimes();
            return Ok(Animes);
        }

        // GET api/<AnimeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AnimeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AnimeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnimeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
