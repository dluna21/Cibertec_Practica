using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class EmployessData:BaseDataAccess<Employees>
    {
        public Employees getEmployeeByID(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Employee.FirstOrDefault<Employees>(x=>x.EmployeeID==id);
            }
        }
    }
}
