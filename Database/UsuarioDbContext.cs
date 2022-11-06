
using Microsoft.EntityFrameworkCore;
using projetomonitoria.Model;

namespace projetomonitoria.Database
{
    public class UsuarioDbContext : DbContext
    {
      public UsuarioDbContext(DbContextOptions<UsuarioDbContext>
      options) : base(options){

      } 

      public DbSet<Usuario> Usuarios {get; set; } 
 
      }
    }
