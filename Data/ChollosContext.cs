using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebJobChollos.Models;

namespace WebJobChollos.Data
{
    public class ChollosContext: DbContext
    {
        public ChollosContext() : base("name=cadenachollos") { }
        public DbSet<CholloBbdd> Chollos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ChollosContext>(null);
        }
    }
}
