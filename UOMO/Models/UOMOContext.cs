using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace UOMO.Models
{
    public partial class UOMOContext : DbContext
    {
        public UOMOContext()
        {
        }

        public UOMOContext(DbContextOptions<UOMOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<Box> Boxes { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WishList> WishLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-353APLF\\SQLEXPRESS;Database=UOMO;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Basket>(entity =>
            {
                entity.ToTable("Basket");

                entity.HasOne(d => d.BasketColor)
                    .WithMany(p => p.Baskets)
                    .HasForeignKey(d => d.BasketColorId)
                    .HasConstraintName("FK__Basket__BasketCo__76969D2E");

                entity.HasOne(d => d.BasketProduct)
                    .WithMany(p => p.Baskets)
                    .HasForeignKey(d => d.BasketProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Basket__BasketPr__3D5E1FD2");

                entity.HasOne(d => d.BasketSize)
                    .WithMany(p => p.Baskets)
                    .HasForeignKey(d => d.BasketSizeId)
                    .HasConstraintName("FK__Basket__BasketSi__778AC167");

                entity.HasOne(d => d.BasketUser)
                    .WithMany(p => p.Baskets)
                    .HasForeignKey(d => d.BasketUserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Basket__BasketUs__3E52440B");
            });

            modelBuilder.Entity<Box>(entity =>
            {
                entity.ToTable("Box");

                entity.Property(e => e.BoxColor).HasMaxLength(30);

                entity.Property(e => e.BoxSize).HasMaxLength(30);

                entity.HasOne(d => d.BoxCargo)
                    .WithMany(p => p.Boxes)
                    .HasForeignKey(d => d.BoxCargoId)
                    .HasConstraintName("FK__Box__BoxCargoId__5DCAEF64");

                entity.HasOne(d => d.BoxProduct)
                    .WithMany(p => p.Boxes)
                    .HasForeignKey(d => d.BoxProductId)
                    .HasConstraintName("FK__Box__BoxProductI__00200768");

                entity.HasOne(d => d.BoxUser)
                    .WithMany(p => p.Boxes)
                    .HasForeignKey(d => d.BoxUserId)
                    .HasConstraintName("FK__Box__BoxUserId__619B8048");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.ToTable("Cargo");

                entity.Property(e => e.CargoDate).HasColumnType("datetime");

                entity.HasOne(d => d.CargoLevel)
                    .WithMany(p => p.Cargos)
                    .HasForeignKey(d => d.CargoLevelId)
                    .HasConstraintName("FK__Cargo__CargoLeve__7D439ABD");

                entity.HasOne(d => d.CargoUser)
                    .WithMany(p => p.Cargos)
                    .HasForeignKey(d => d.CargoUserId)
                    .HasConstraintName("FK__Cargo__CargoUser__7F2BE32F");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.Property(e => e.ColorName).HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryName).HasMaxLength(50);
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.Property(e => e.LevelName).HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderPrice).HasMaxLength(50);

                entity.Property(e => e.OrderStatus).HasMaxLength(40);

                entity.HasOne(d => d.OrderBox)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderBoxId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Orders__OrderBox__5629CD9C");

                entity.HasOne(d => d.OrderUser)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderUserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Orders__OrderUse__5535A963");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.ToTable("Photo");

                entity.Property(e => e.PhotoUrl).HasColumnName("PhotoURL");

                entity.HasOne(d => d.PhotoProduct)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.PhotoProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Photo__PhotoProd__47DBAE45");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductDescription).HasMaxLength(4000);

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK_ProductCategory");

                entity.HasOne(d => d.ProductColor)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductColorId)
                    .HasConstraintName("FK__Product__Product__6B24EA82");

                entity.HasOne(d => d.ProductSize)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductSizeId)
                    .HasConstraintName("FK__Product__Product__6E01572D");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("Size");

                entity.Property(e => e.SizeName).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserCity).HasMaxLength(20);

                entity.Property(e => e.UserEmail).HasMaxLength(100);

                entity.Property(e => e.UserGender).HasMaxLength(20);

                entity.Property(e => e.UserName).HasMaxLength(20);

                entity.Property(e => e.UserNickName).HasMaxLength(100);

                entity.Property(e => e.UserPassword).HasMaxLength(100);

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserRole).HasMaxLength(20);

                entity.Property(e => e.UserStreetAdress).HasMaxLength(500);

                entity.Property(e => e.UserSurname).HasMaxLength(20);

                entity.HasOne(d => d.UserCountry)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserCountryId)
                    .HasConstraintName("FK_User_Country");
            });

            modelBuilder.Entity<WishList>(entity =>
            {
                entity.HasKey(e => e.WishId)
                    .HasName("PK__WishList__64BA62A164BA1A41");

                entity.ToTable("WishList");

                entity.HasOne(d => d.WishProduct)
                    .WithMany(p => p.WishLists)
                    .HasForeignKey(d => d.WishProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__WishList__WishPr__4AB81AF0");

                entity.HasOne(d => d.WishUser)
                    .WithMany(p => p.WishLists)
                    .HasForeignKey(d => d.WishUserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__WishList__WishUs__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
