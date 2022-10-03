using Assignment_4_REST.Managers;
using AutumnAssignmentFootball;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_4_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballController : ControllerBase
    {
        private readonly FootballManager _manager = new FootballManager();
        // GET: api/<FootballController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<FootballPlayer> Get(string substring)
        {
            _manager.GetAll(substring);
            if (null == _manager.GetAll(substring)) return NotFound("Empty");
            return Ok();
        }

        // GET api/<FootballController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<FootballPlayer> Get(int id)
        {
            _manager.GetById(id);
            if (id == null) return NotFound("No such class, id: " + id);
            return Ok(id);
        }

        // POST api/<FootballController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<FootballPlayer> Post([FromBody] FootballPlayer value)
        {
            _manager.Add(value);
            if (value == null) return NotFound("Post can't be empty or null");
            return Ok(value);
        }

        // PUT api/<FootballController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<FootballPlayer> Put(int id, [FromBody] FootballPlayer value)
        {
            _manager.Update(id, value);

            return Ok(id);
        }

        // DELETE api/<FootballController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<FootballPlayer> Delete(int id)
        {
            _manager.Delete(id);
            if (id == null) return NotFound("you've deleted nothing");

            return Ok(id);
        }
    }
}
