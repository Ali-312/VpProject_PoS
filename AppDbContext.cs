using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VpProject_PoS
{
    internal class AppDbContext : DbContext
    {
        public DbSet<InvoiceItem> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Connection string for local SQL Server
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=PoS_Database;Trusted_Connection=True;");
        }
    }
}
