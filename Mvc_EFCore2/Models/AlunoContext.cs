using Microsoft.EntityFrameworkCore;

namespace Mvc_EFCore2.Models
{
    public class AlunoContext : DbContext
    {
        public AlunoContext(DbContextOptions<AlunoContext> options) : base(options){}

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<TipoSocio> TipoSocios { get; set; }
    }
}
