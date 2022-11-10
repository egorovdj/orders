using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Hosting;
using Orders.Models;

namespace Orders.Models
{
    public partial class OrdersDBContext : DbContext
    {
        public OrdersDBContext(DbContextOptions<OrdersDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Provider> Providers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=OrdersDBContext;Trusted_Connection=True;MultipleActiveResultSets=true");
                //optionsBuilder.UseSqlServer("Data Source=ms-sql-8.in-solve.ru;Initial Catalog=1gb_indeas;User ID=1gb_egorovdj;Password=3zzbbc78bqwr;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provider>().HasData(
                new { Id = 1, Name = "Samsung" },
                new { Id = 2, Name = "Huawei" },
                new { Id = 3, Name = "Apple" },
                new { Id = 4, Name = "Xiaomi" },
                new { Id = 5, Name = "OPPO" },
                new { Id = 6, Name = "Vivo" },
                new { Id = 7, Name = "Lenovo" },
                new { Id = 8, Name = "Google" },
                new { Id = 9, Name = "OnePlus" },
                new { Id = 10, Name = "Honor" },
                new { Id = 11, Name = "Nokia" },
                new { Id = 12, Name = "BBK" },
                new { Id = 13, Name = "LG" },
                new { Id = 14, Name = "Sony" },
                new { Id = 15, Name = "ASUS" },
                new { Id = 16, Name = "Infinix" },
                new { Id = 17, Name = "Motorola" },
                new { Id = 18, Name = "Alcatel" },
                new { Id = 19, Name = "Realme" },
                new { Id = 20, Name = "Poco" }
                );
            modelBuilder.Entity<Order>().HasData(
                new { Id = 1, ProviderId = 3, Number = "A-123", Date =   DateTime.Parse("17-08-2022 0:00") },
                new { Id = 2, ProviderId = 1, Number = "S-123", Date =   DateTime.Parse("01-08-2022 0:00") },
                new { Id = 3, ProviderId = 8, Number = "G-123", Date =   DateTime.Parse("05-08-2022 0:00") },
                new { Id = 4, ProviderId = 9, Number = "O-123", Date =   DateTime.Parse("25-08-2022 0:00") },
                new { Id = 5, ProviderId = 4, Number = "X-123", Date =   DateTime.Parse("31-08-2022 0:00") },
                new { Id = 6, ProviderId = 3, Number = "A-124", Date =   DateTime.Parse("15-09-2022 0:00") },
                new { Id = 7, ProviderId = 4, Number = "X-124", Date =   DateTime.Parse("05-09-2022 0:00") },
                new { Id = 8, ProviderId = 19, Number = "R-124", Date =  DateTime.Parse("25-09-2022 0:00") },
                new { Id = 9, ProviderId = 1, Number = "S-124", Date =   DateTime.Parse("03-09-2022 0:00") },
                new { Id = 10, ProviderId = 4, Number = "X-125", Date =  DateTime.Parse("15-10-2022 0:00") },
                new { Id = 11, ProviderId = 4, Number = "X-126", Date =  DateTime.Parse("01-10-2022 0:00") },
                new { Id = 12, ProviderId = 1, Number = "S-125", Date =  DateTime.Parse("25-10-2022 0:00") },
                new { Id = 13, ProviderId = 1, Number = "S-126", Date =  DateTime.Parse("05-10-2022 0:00") },
                new { Id = 14, ProviderId = 5, Number = "OP-123", Date = DateTime.Parse("05-11-2022 0:00") },
                new { Id = 15, ProviderId = 10, Number = "H-123", Date = DateTime.Parse("01-11-2022 0:00") },
                new { Id = 16, ProviderId = 20, Number = "P-123", Date = DateTime.Parse("03-11-2022 0:00") },
                new { Id = 17, ProviderId = 4, Number = "X-127", Date =  DateTime.Parse("05-08-2022 0:00") },
                new { Id = 18, ProviderId = 16, Number = "I-123", Date = DateTime.Parse("01-08-2022 0:00") },
                new { Id = 19, ProviderId = 19, Number = "R-123", Date = DateTime.Parse("25-08-2022 0:00") },
                new { Id = 20, ProviderId = 1, Number = "S-127", Date =  DateTime.Parse("31-08-2022 0:00") }
                );
            modelBuilder.Entity<OrderItem>().HasData(
                new { Id = 1, OrderId = 1, Name = "iPhone 14 Pro/Pro Max", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 2, OrderId = 2, Name = "Galaxy S21 FE 5G", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 3, OrderId = 3, Name = "Pixel 6 Pro", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 4, OrderId = 4, Name = "OnePlus 9 Pro", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 5, OrderId = 5, Name = "Mi 11 Ultra", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 6, OrderId = 6, Name = "iPhone 13 mini", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 7, OrderId = 7, Name = "11T Pro", Quantity = 50.23M, Unit = "тыс.шт."},
                new { Id = 8, OrderId = 8, Name = "Realme GT 5G", Quantity = 50.23M, Unit = "тыс.шт."},
                new { Id = 9, OrderId = 9, Name = "Galaxy Z Fold3 5G", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 10, OrderId = 10, Name = "Redmi 10 NFC", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 11, OrderId = 11, Name = "Redmi Note 10 Pro", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 12, OrderId = 12, Name = "Galaxy Z Flip3 5G", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 13, OrderId = 13, Name = "Galaxy A72", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 14, OrderId = 14, Name = "OPPO Reno 6", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 15, OrderId = 15, Name = "Honor 50", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 16, OrderId = 16, Name = "Poco X3 Pro", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 17, OrderId = 17, Name = "Redmi 9T NFC", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 18, OrderId = 18, Name = "Infinix Hot 11S", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 19, OrderId = 19, Name = "Realme 9i", Quantity = 50.23M, Unit = "тыс.шт." },
                new { Id = 20, OrderId = 20, Name = "Galaxy A03", Quantity = 50.23M, Unit = "тыс.шт." }
                );
        }
    }
}
