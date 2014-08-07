using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_VS2014.Entities;

namespace CodeFirst_VS2014
{
    class Program
    {
        static void Main(string[] args)
        {

            CreateCategory();

            CreateSubCategory(3);

            var data = GetCategories().ToList();

            foreach (var item in data)
            {
                Console.WriteLine(item.CategoryName);
                if (item.ParentId.HasValue)
                {
                    Console.WriteLine(string.Format("Parent : {0}",item.Parent.CategoryName));
                }
            }
        }


        static void CreateSubCategory(int parentId)
        {
            using (var ctx = new CodeFirstDbContext())
            {
                var child = new Category
                {
                    CategoryName = "child_C" + DateTime.Now.Ticks,
                    ParentId = parentId
                };

                ctx.Categories.Add(child);
                ctx.SaveChanges();
            }
        }

        static IEnumerable<Category> GetCategories()            
        {
            var ctx = new CodeFirstDbContext();

            return ctx.Categories.ToList();
        }

        static void CreateCategory()
        {
            using (var ctx = new CodeFirstDbContext())
            {
                Category c = new Category
                {
                    CategoryName = "C" + DateTime.Now.Ticks
                };

                ctx.Categories.Add(c);
                ctx.SaveChanges();
            }


        }
    }
}
