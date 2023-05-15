using Levva.Newbies.Intensivo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Levva.Newbies.Intensivo.Data
{
    public class Context : DbContext
    {
        public DbSet<UsuarioDto> Usuario { get; set; }
        public DbSet<TransacaoDto> Transacao { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public Context(DbContextOptions<Context> options): base(options) { }
    }
}
