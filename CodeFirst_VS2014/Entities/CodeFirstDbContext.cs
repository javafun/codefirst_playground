using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_VS2014.EntityMappings;

namespace CodeFirst_VS2014.Entities
{
    public class CodeFirstDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public CodeFirstDbContext()
        {
            Console.WriteLine(Database.Connection.ConnectionString);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*
                EF6 has handle by default, therefore the following configuration is not longer required.
                It's only for reference purpose, if you are using EF5, you do need this.
            */
            //modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }
}
