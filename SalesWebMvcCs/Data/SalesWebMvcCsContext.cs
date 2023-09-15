using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcCs.Models;

namespace SalesWebMvcCs.Data
{
    public class SalesWebMvcCsContext : DbContext
    {
        public SalesWebMvcCsContext (DbContextOptions<SalesWebMvcCsContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
