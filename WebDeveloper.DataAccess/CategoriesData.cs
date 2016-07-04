using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class CategoriesData:BaseDataAccess<Category>
    {
        public Category getCategorieByID(int? id) {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Categorie.FirstOrDefault(x => x.CategoryID == id);
            }
        }
    }
}
