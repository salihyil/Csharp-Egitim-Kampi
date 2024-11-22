using CSharpEgitimKampi301.EntityLayer.Concrete;
using System.Data.Entity;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class CampContext : DbContext
    {
        // DbSet içine entity katmanında yer alan tabloları ekliyoruz.
        // Categories sql'e yansıyacak olan tablo
        // pluralize -> sınıfla tablo birbirinin içerisine girmesin diye yalın hali csharpda çogul hali sql de kullan.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
