using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_VS2014.Entities
{
    public class Category
    {
        public long Id { get; set; }
        public string CategoryName { get; set; }
        public long? ParentId { get; set; }
        public Category Parent { get; set; }
        public virtual ICollection<Category> SubCategories { get; set; }

        public DateTime LastModified { get;set; }
    }
}
