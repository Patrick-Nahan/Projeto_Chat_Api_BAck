using Microsoft.EntityFrameworkCore;
using Projeto_Chat.Models;

namespace Projeto_Chat.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Username> Usersdb { get; set; }
        public DbSet<Chat> chatdb { get; set; }
        
    }
}
