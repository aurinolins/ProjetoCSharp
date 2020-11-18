using Microsoft.EntityFrameworkCore;
using app02.Models.Entidades;
using app02.Models;

namespace app02.Data
{
    public class app02Context : DbContext
    {
        public app02Context (DbContextOptions<app02Context> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Titulo> Titulos { get; set; }

        public DbSet<Indices> Indices { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
