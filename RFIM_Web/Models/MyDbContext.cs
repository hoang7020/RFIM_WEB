using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
<<<<<<< HEAD
/*To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.*/
=======
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
<<<<<<< HEAD
>>>>>>> dev_test5
                optionsBuilder.UseSqlServer("Server=rfimv2.cvorgj7da36w.ap-southeast-1.rds.amazonaws.com;Database=RFIM_DB;User Id=sa;Password=hoangdien");
=======
                optionsBuilder.UseSqlServer("Server=rfim.clvgsqcm7dqf.ap-southeast-1.rds.amazonaws.com;Database=RFIM_DB;User Id=sa;Password=hoangdien");
>>>>>>> parent of aef0517... fix session, validate vendor
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Invoice_Product>().HasKey(table => new { table.InvoiceId, table.ProductId });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Shelf> Shelfs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Box> Boxes { get; set; }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceType> InvoiceTypes { get; set; }
        public DbSet<Invoice_Product> Invoice_Products { get; set; }
        public DbSet<StocktakeHistory> StocktakeHistories { get; set; }
        public DbSet<StandardShelfSize> StandardShellSizes { get; set; }
        public DbSet<InvoiceStatus> InvoiceStatuses { get; set; }
    }
}
