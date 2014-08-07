using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_VS2014.Entities;

namespace CodeFirst_VS2014.EntityMappings
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            HasKey(x => x.Id);

            HasMany(x => x.SubCategories)
                .WithOptional(x => x.Parent)
                .HasForeignKey(x => x.ParentId)
                .WillCascadeOnDelete(false);

        }
    }
}
