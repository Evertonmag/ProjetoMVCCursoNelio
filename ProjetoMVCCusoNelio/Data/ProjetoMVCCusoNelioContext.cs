using Microsoft.EntityFrameworkCore;
using ProjetoMVCCusoNelio.Models;

namespace ProjetoMVCCusoNelio.Data
{
    public class ProjetoMVCCusoNelioContext : DbContext
    {
        public ProjetoMVCCusoNelioContext (DbContextOptions<ProjetoMVCCusoNelioContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
