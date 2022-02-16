using ProjetoMVCCusoNelio.Data;
using ProjetoMVCCusoNelio.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoMVCCusoNelio.Services
{
    public class SellerService
    {
        private readonly ProjetoMVCCusoNelioContext _context;

        public SellerService(ProjetoMVCCusoNelioContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
