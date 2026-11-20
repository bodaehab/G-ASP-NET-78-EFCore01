using G_ASP_NET_78_EFCore01.data;
using Microsoft.EntityFrameworkCore;

namespace G_ASP_NET_78_EFCore01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            using var context = new AppDbContext();

            context.Database.EnsureCreated();

            Console.WriteLine("Database created successfully!");

            Console.WriteLine("Database Name: " +
                context.Database.GetDbConnection().Database);

            Console.WriteLine("Books Table: " +
                context.Books.Count());

            Console.WriteLine("Authors Table: " +
                context.Authors.Count());

            Console.WriteLine("Categories Table: " +
                context.Categories.Count());
        }
    }
}
