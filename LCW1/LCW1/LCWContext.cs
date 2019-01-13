using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCW1
{
    class LCWContext
        : DbContext
    {
        public LCWContext()
            : base("LCWDB") { }

        public DbSet<Characteristic> Characteristics { get; set; }
        public DbSet<CharacteristicComp> CharacteristicsComps { get; set; }
        //public DbSet<Client> Clients { get; set; }
        public DbSet<CompComponent> CompComponents { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<LCWContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
