using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            var listCategorys = new List<Category>();
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    listCategorys = context.Categories.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            return listCategorys;
        }
        public static Category FindCategoryById(int categoryId)
        {
            Category p = new Category();
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    p = context.Categories.SingleOrDefault(x => x.ID == categoryId);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            return p;
        }
        public static void SaveCategory(Category p)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Categories.Add(p);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }
        public static void UpdateCategory(Category p)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Entry<Category>(p).State =
                        Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }
        public static void DeleteCategory(Book p)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var p1 = context.Categories.SingleOrDefault(c => c.ID == p.ID);
                    context.Categories.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }
    }
}
