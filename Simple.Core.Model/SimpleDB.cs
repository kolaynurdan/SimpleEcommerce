using Simple.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Core.Model
{
    public class SimpleDB:DbContext
    {
        //Tablolar
        public SimpleDB()
            : base(@"Data Source=.;Initial Catalog=SimpleDB;Integrated Security=True")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<Basket> Baskets { get; set; }

        public DbSet<Order> Orders{ get; set; }

        public DbSet<OrderProduct> OrderProducts { get; set; }

        public DbSet<OrderPayment> OrderPayments { get; set; }

        //public DbSet<object> Addresses { get; set; }

        //public object Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);

        }


    }
}
 