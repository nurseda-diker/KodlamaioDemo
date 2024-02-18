using KodlamaioSimulation.DataAccess.Abstract;
using KodlamaioSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        List<Category> categories;

        public EfCategoryDal()
        {
             Category category1 = new Category();
             category1.Id = 1;
             category1.Name = "Programlama" ;


             Category category2 = new Category();
             category2.Id = 2;
             category2.Name = "Algoritma";

             categories=new List<Category>() { category1, category2 };
        }


        public void Add(Category category)
        {
            categories.Add(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Remove(Category category)
        {
            categories.Remove(category);
        }

        public void Update(Category category)
        {
            Category updatedCategory=categories.SingleOrDefault(c=>c.Id==category.Id);
            category.Name= updatedCategory.Name;
        }
    }
}
