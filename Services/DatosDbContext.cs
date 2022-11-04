using Microsoft.EntityFrameworkCore;
using Becas.Models;

namespace Becas
{
    public class DatosDbContext : DbContext
    {
      public DatosDbContext (DbContextOptions options) : base (options)
    {

    }
    
    public DbSet<Alumnos> Alumnos {get; set;}
    }
}
