using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using app02.Models.Entidades;
using app02.Repository;

namespace app02.Data
{
    public class app02Context : IdentityDbContext
    {
        public app02Context (DbContextOptions<app02Context> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Titulo> Titulos { get; set; }

        public DbSet<Indices> Indices { get; set; }

        public DbSet<SignUpUser> SignUpUsers { get; set; }
        public DbSet<AccountRepository> AccoutRepository { get; set; }
        public DbSet<IAccountRepository> IAccoutRepository { get; set; }
    }
}

