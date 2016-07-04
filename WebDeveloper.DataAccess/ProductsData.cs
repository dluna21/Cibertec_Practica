using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductsData:BaseDataAccess<Products>
    {
        public Products getProductById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Product.FirstOrDefault(x => x.ProductID == id);
            }
        }
    }
}
