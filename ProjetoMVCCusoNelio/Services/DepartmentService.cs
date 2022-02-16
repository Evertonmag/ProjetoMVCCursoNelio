using ProjetoMVCCusoNelio.Data;
using ProjetoMVCCusoNelio.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoMVCCusoNelio.Services
{
    public class DepartmentService
    {
        private readonly ProjetoMVCCusoNelioContext _context;

        public DepartmentService(ProjetoMVCCusoNelioContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }


    }
}
