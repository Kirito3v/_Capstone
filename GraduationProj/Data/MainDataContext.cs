using GraduationProj.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace GraduationProj.Data
{
    public class MainDataContext:DbContext
    {

        public MainDataContext(DbContextOptions<MainDataContext> options):base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ProductTrait> AllProductsTraits { get; set; }
        public DbSet<ProductDetails> ProductsDetails { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ProductWishlist> productWishlists { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }

        public DbSet<ShippingInfo> ShippingInfos { get; set; }
        public DbSet<UserItems> UserItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductDetails>()
              .HasMany(d => d.RelatedProducts)
              .WithMany()    
              .UsingEntity<Dictionary<string, object>>("ProductDetailsRelatedProducts");

            modelBuilder.Entity<Product>()
               .HasOne(p => p.Details)
               .WithOne(d => d.product)
               .HasForeignKey<ProductDetails>(d => d.ProductId);

            modelBuilder.Entity<ProductDetails>()
                .HasMany(d => d.Traits)
                .WithOne(t => t.Details)
                .HasForeignKey(t => t.ProductDetailsId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProductDetails>()
                .Property(d => d.ImagePaths)
                .HasConversion(
                    v => string.Join(',', v),              // List<string> => string for DB
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)  // string => List<string>
                );

            modelBuilder.Entity<Cart>()
                .HasMany(c => c.CartItems)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CartItem>()
                .HasOne(ci=>ci.Product)
                .WithMany()
                .HasForeignKey(ci=>ci.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CartItem>()
            .HasIndex(ci => new { ci.CartId, ci.ProductId })
            .IsUnique();


            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasOne(i => i.UserItems)
                .WithOne(i => i.Account)
                .HasForeignKey<Account>(i => i.UserItemsId);
       


                entity.HasIndex(a => a.Email)
                      .IsUnique();  // ensure no duplicate emails

                entity.Property(a => a.FullName)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(a => a.PasswordHash)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(a => a.CreatedAt)
                      .HasDefaultValueSql("GETUTCDATE()");
            });

            modelBuilder.Entity<UserItems>(entity =>
            {
               
                entity.HasKey(i=>i.Id);

                entity.HasOne(ui => ui.Cart)
                      .WithOne(a => a.UserItems)
                      .HasForeignKey<UserItems>(ui => ui.CartId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(ui => ui.Address)
                      .WithOne(a => a.UserItems)
                      .HasForeignKey<UserItems>(ui => ui.AddressId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(ui => ui.Wishlist)
                      .WithOne(a => a.UserItems)
                      .HasForeignKey<UserItems>(ui => ui.WishlistId);
                
            });


            modelBuilder.Entity<ProductWishlist>(entity =>
            {
                // 1) Composite PK
                entity.HasKey(pw => new { pw.ProductId, pw.WishlistId });

                // 2) Link back to Product
                entity.HasOne(pw => pw.Product)
                      .WithMany()                // no nav on Product
                      .HasForeignKey(pw => pw.ProductId);

                // 3) Link back to Wishlist
                entity.HasOne(pw => pw.Wishlist)
                      .WithMany(w => w.ProductWishlists) // your Wishlist.Products nav
                      .HasForeignKey(pw => pw.WishlistId);
            });

    

        }

    }
}
