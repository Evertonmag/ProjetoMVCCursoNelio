using Microsoft.EntityFrameworkCore;
using ProjetoMVCCusoNelio.Data;
using ProjetoMVCCusoNelio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVCCusoNelio.Services
{
    public class DepartmentService
    {
        private readonly ProjetoMVCCusoNelioContext _context;

        public DepartmentService(ProjetoMVCCusoNelioContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }


    }
}
