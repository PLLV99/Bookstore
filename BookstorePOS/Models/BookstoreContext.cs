using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Bookstore.Models.DataLayer
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public BookstoreContext() { }

        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BookstoreConnection"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Books").HasKey(b => b.BookId);
            modelBuilder.Entity<Purchase>().ToTable("Purchases").HasKey(p => p.PurchaseId);
            modelBuilder.Entity<User>().ToTable("Users").HasKey(u => u.UserId);
            modelBuilder.Entity<CartItem>().ToTable("CartItems").HasKey(c => c.CartId);

            modelBuilder.Entity<Book>()
                .HasIndex(b => b.ISBN)
                .IsUnique();

            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.Book)
                .WithMany(b => b.Purchases)
                .HasForeignKey(p => p.BookId);

            modelBuilder.Entity<CartItem>()
                .HasOne(c => c.Book)
                .WithMany(b => b.CartItems)
                .HasForeignKey(c => c.BookId);

            modelBuilder.Entity<CartItem>()
                .HasOne(c => c.User)
                .WithMany(u => u.CartItems)
                .HasForeignKey(c => c.UserId);

        }
    }
}