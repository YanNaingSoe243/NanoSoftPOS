using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSoftGreenMark.Data
{
    public class NanoContext : DbContext
    {
        public NanoContext() { }
       
        public NanoContext(DbContextOptions<NanoContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            // optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["NanoSoftConnect"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Purchase>()
              .HasMany<PurchaseItem>(g => g.PurchaseProdcuts)
              .WithOne(s => s.Purchase)
              .HasForeignKey(s => s.PurchaseFK).OnDelete(DeleteBehavior.ClientSetNull);

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductProperty> productProperties { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<BankList> BankLists { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DiscountProduct> DiscountProducts {get;set;}
        public DbSet<DiscountType> DiscountTypes { get; set; }
        public DbSet<GiftCard> GiftCards { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<DeliveryLog> DeliveryLogs { get; set; }

    }
}
