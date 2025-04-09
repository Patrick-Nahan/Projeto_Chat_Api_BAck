using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_Chat.Data;
using Projeto_Chat.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Projeto_Chat.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatControler : ControllerBase
    {
        private readonly AppDbContext _context;

        public ChatControler(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<username>>> GetUser(username username)
        {
            return await _context.Usersdb.ToListAsync();
        }

        // GET api/<ChatControler>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ChatControler>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
