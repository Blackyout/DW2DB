using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DW2DBContext : DbContext
    {
        public DW2DBContext()
            : base("name=DW2DBContext")
        {
           
        }


        public virtual DbSet<Digimon> Digimons { get; set; }
        public virtual DbSet<DigivolveDNA> DigivolveDnas { get; set; }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            base.OnModelCreating(mb);
            mb.Entity<Digimon>().HasMany(x=>x.Locations).WithRequired(x=>x.Digimon).WillCascadeOnDelete(true);
            mb.Entity<Digimon>().HasMany(x=>x.Skills).WithRequired(x=>x.Digimon).WillCascadeOnDelete(true);

//            mb.Entity<Digimon>().Property(p => p.Id)
//                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            // mb.Entity<Location>().Map(x=>x.Property(x.)).Property()

            // mb.Entity<Digimon>().HasKey(x => x.Id);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}