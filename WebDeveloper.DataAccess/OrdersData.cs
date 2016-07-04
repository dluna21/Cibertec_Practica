using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class OrdersData:BaseDataAccess<Orders>
    {
        public Orders getOrderByID(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Order.FirstOrDefault(x => x.OrderID == id);
            }
        }
    }
}
