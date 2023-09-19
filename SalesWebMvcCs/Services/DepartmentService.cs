using SalesWebMvcCs.Data;
using SalesWebMvcCs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvcCs.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcCsContext _context;

        public DepartmentService(SalesWebMvcCsContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
