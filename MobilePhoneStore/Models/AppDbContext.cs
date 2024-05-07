using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MobilePhoneStore.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Phone> Phones { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer() { Id = 1, Name = "Huawei", Country = "China" },
                new Manufacturer() { Id = 2, Name = "Xiaomi", Country = "China" },
                new Manufacturer() { Id = 3, Name = "Honor", Country = "China" },
                new Manufacturer() { Id = 4, Name = "Apple", Country = "SAD" },
                new Manufacturer() { Id = 5, Name = "Samsung", Country = "Japan" }
            );

            modelBuilder.Entity<Phone>().HasData(
                new Phone() { Id = 1, Model = "iPhone 13", OperatingSystem = "IOS", AvailableQuantity = 17, Price = 530.0, Photo = "https://www.tehnomedia.rs/image/85400.jpg?tip=webp&tip_slike=0", ManufacturerId = 4 },
                new Phone() { Id = 2, Model = "iPhone 14", OperatingSystem = "IOS", AvailableQuantity = 12, Price = 625.0, Photo = "https://www.tehnomedia.rs/image/91914.jpg?tip=webp&tip_slike=0", ManufacturerId = 4 },
                new Phone() { Id = 3, Model = "iPhone 15 Pro", OperatingSystem = "IOS", AvailableQuantity = 10, Price = 1180.0, Photo = "https://www.tehnomedia.rs/image/100132.jpg?tip=webp&tip_slike=0", ManufacturerId = 4 },
                new Phone() { Id = 4, Model = "iPhone 15", OperatingSystem = "IOS", AvailableQuantity = 4, Price = 740.0, Photo = "https://www.tehnomedia.rs/image/100086.jpg?tip=webp&tip_slike=0", ManufacturerId = 4 },
                new Phone() { Id = 5, Model = "Galaxy Z Fold", OperatingSystem = "Android", AvailableQuantity = 7, Price = 1250.0, Photo = "https://img.ep-cdn.com/i/500/500/al/alhkinftrpeswyxbgvou/samsung-galaxy-z-fold-4-12gb-256gb-black-cene.jpg", ManufacturerId = 5 },
                new Phone() { Id = 6, Model = "Galaxy S24 Ultra", OperatingSystem = "Android", AvailableQuantity = 5, Price = 1260.0, Photo = "https://www.tehnomedia.rs/image/102822.jpg?tip=webp&tip_slike=0", ManufacturerId = 5 },
                new Phone() { Id = 7, Model = "Galaxy S23 Ultra", OperatingSystem = "Android", AvailableQuantity = 0, Price = 1552.0, Photo = "https://www.tehnomedia.rs/image/95008.jpg?tip=webp&tip_slike=0", ManufacturerId = 5 },
                new Phone() { Id = 8, Model = "Galaxy A55", OperatingSystem = "Android", AvailableQuantity = 2, Price = 466.0, Photo = "https://www.tehnomedia.rs/image/104507.jpg?tip=webp&tip_slike=0", ManufacturerId = 5 },
                new Phone() { Id = 9, Model = "P60 Pro", OperatingSystem = "Android", AvailableQuantity = 7, Price = 951.0, Photo = "https://img.gigatron.rs/img/products/large/image6467404c20680.jpg", ManufacturerId = 1 },
                new Phone() { Id = 10, Model = "nova 11", OperatingSystem = "Android", AvailableQuantity = 5, Price = 430.0, Photo = "https://img.gigatron.rs/img/products/large/image652e84afa707f.jpg", ManufacturerId = 1 },
                new Phone() { Id = 11, Model = "nova 10 SE", OperatingSystem = "Android", AvailableQuantity = 0, Price = 291.0, Photo = "https://img.gigatron.rs/img/products/large/image63c52aab38686.jpg", ManufacturerId = 1 },
                new Phone() { Id = 12, Model = "14 Ultra", OperatingSystem = "Android", AvailableQuantity = 12, Price = 1200.0, Photo= "https://www.giztop.com/media/catalog/product/cache/dc206057cdd42d7e34b9d36e347785ca/x/i/xiaomi_14_ultra_white.jpg", ManufacturerId = 2 },
                new Phone() { Id = 13, Model = "14", OperatingSystem = "Android", AvailableQuantity = 15, Price = 855.0, Photo = "https://www.tehnomedia.rs/image/103970.jpg?tip=webp&tip_slike=0", ManufacturerId = 2 },
                new Phone() { Id = 14, Model = "13T Pro", OperatingSystem = "Android", AvailableQuantity = 9, Price = 748.0, Photo = "https://mi-srbija.rs/storage/product/images/4c/55/xiaomi-13t-pro-6539.png", ManufacturerId = 2 },
                new Phone() { Id = 15, Model = "Magic6 Pro", OperatingSystem = "Android", AvailableQuantity = 12, Price = 1090.0, Photo = "https://www.honor.com/content/dam/honor/my/product-list/smartphone/honor-magic6-pro/honor-magic6-pro-green.png", ManufacturerId = 3 },
                new Phone() { Id = 16, Model = "90 5G", OperatingSystem = "Android", AvailableQuantity = 4, Price = 440.0, Photo = "https://img.gigatron.rs/img/products/large/image64a7ec239245d.jpg", ManufacturerId = 3 },
                new Phone() { Id = 17, Model = "Magic5 Lite", OperatingSystem = "Android", AvailableQuantity = 2, Price = 195.0, Photo = "https://api.tehnoteka.rs/uploads/cache/product_4x3/uploads/2024/01/honor-magic5-lite-8-256gb-emerald-green-659e89d880e04.jpeg", ManufacturerId = 3 },
                new Phone() { Id = 18, Model = "X8a", OperatingSystem = "Android", AvailableQuantity = 5, Price = 141.0, Photo = "https://e-mobilni.rs/wp-content/uploads/2023/11/mobilni-telefon-honor-x8a-67-6gb-128gb-plavi-190763-291451.png", ManufacturerId = 3 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
