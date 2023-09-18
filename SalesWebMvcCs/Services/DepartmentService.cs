using SalesWebMvcCs.Data;
using SalesWebMvcCs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcCs.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcCsContext _context;

        public DepartmentService(SalesWebMvcCsContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
