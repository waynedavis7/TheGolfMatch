using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheMatch.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheMatch.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatchController : ControllerBase
    {
        private readonly IMatchRepository _matchRepository;

        public MatchController(TheMatch.Domain.IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<TheMatch.Domain.Match> Get()
        {
            return _matchRepository.GetMatches();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public TheMatch.Domain.Match Get(int id)
        {
            return _matchRepository.GetMatch(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] TheMatch.Domain.Match value)
        {
            _matchRepository.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TheMatch.Domain.Match value)
        {

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
