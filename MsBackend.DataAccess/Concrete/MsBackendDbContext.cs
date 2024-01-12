using Microsoft.EntityFrameworkCore;
using MSBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsBackend.DataAccess.Concrete
{
    public class MsBackendDbContext:DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TOKAT153;Database=MsBackendDb;TrustServerCertificate=True;Trusted_Connection=true");
           
        }

        public DbSet<Product> Products { get; set; }
    }
}
