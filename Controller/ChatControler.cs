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
        public async Task<ActionResult<IEnumerable<Username>>> GetUser(Username username)
        {
            if (_context.Usersdb == null)
            {
                return NotFound();
            }
            return await _context.Usersdb.ToListAsync();
        }

        // GET api/<ChatControler>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Username>>GetUser(int id)
        {
            if (_context.Usersdb == null)
            {
                return NotFound();
            }

            var userid =await  _context.Usersdb.FindAsync(id);
            if (userid == null)
            {
                return NotFound();
            }
            return userid;
        }

        [HttpPost]
        public async Task<ActionResult<Username>> PostUser([FromBody]Username username)
        {
            _context.Usersdb.Add(username);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUser), new { id = username.IdUsername }, username);
        }
    }
}
