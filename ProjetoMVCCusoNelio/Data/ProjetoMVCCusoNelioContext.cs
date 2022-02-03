using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<ProjetoMVCCusoNelio.Models.Department> Department { get; set; }
    }
}
