using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=JewelryProjectDB; integrated security=true");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<NewArrival> NewArrivals { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Shop_Single> Shop_Singles { get; set; }
        public DbSet<CheckOut> CheckOuts { get; set; }


    }
}
