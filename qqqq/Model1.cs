namespace qqqq
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
            Database.SetInitializer<Model1>(new CustomSuperPuperInitializer<Model1>());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }
        public virtual DbSet<AbsProduct> AbsProducts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<RealProduct> RealProducts { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Adress> Adresses { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Bilding> Bildings { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
