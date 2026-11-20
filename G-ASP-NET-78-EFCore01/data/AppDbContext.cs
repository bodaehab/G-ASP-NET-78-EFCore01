using G_ASP_NET_78_EFCore01.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_78_EFCore01.data;

public  class AppDbContext: DbContext
{
   public  DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories{ get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer("Server=.;Database=ReadMoreBooksDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
