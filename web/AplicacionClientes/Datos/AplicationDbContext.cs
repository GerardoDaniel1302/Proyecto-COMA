using AplicacionClientes.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicacionClientes.Datos
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions <AplicationDbContext> options): base(options)
        {

        }
        //Uso de los modelos
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Factura> Factura { get; set; }
    }
}
