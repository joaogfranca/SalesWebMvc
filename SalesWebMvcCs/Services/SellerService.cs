using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvcCs.Models;
using SalesWebMvcCs.Data;

namespace SalesWebMvcCs.Services
{
    public class SellerService 
    {
        private readonly SalesWebMvcCsContext _context;

        public SellerService(SalesWebMvcCsContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
