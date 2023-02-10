using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLIbrary12
{
    class Bookcontext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Auther>Authers { get; set; }
        public DbSet<BookAuther> BookAuthers { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Libraian> Libraians { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<BookItem> BookItems { get; set;} 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-1NM1FJ1;Database=BooksLibrary;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuther>().HasKey(BA => new { BA.ISBNID, BA.autherID});
        }

    }
}
