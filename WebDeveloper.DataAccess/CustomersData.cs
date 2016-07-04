using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class CustomersData : BaseDataAccess<Customers>
    {
        public Customers getCustomerById(int? id)
        {
            using (var dbDataContext = new WebContextDb())
            {
                return dbDataContext.Customer.FirstOrDefault(x => x.CustomerID == id);
            }
        }
         

    }
}
