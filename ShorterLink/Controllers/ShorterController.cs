using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShorterLink.Repositories;
namespace ShorterLink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShorterController : ControllerBase
    {
        private readonly ILinkRepository _linkRepository;
        public ShorterController(ILinkRepository linkRepository)
        {
            _linkRepository = linkRepository;
        }
        // GET: api/Shorter
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Shorter/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Shorter
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Shorter/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
