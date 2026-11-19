using Microsoft.EntityFrameworkCore;
using ProjetoLogin.Models;

namespace ProjetoLogin.Data
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext(
            DbContextOptions<LivrariaContext> options)
            : base(options)
        {
        }

        public DbSet<Login> Login { get; set; }

        public DbSet<Livro> Livro { get; set; }
    }
}