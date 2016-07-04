using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Helpers
{
    public static class Helper
    {
        public static List<Category> DisplayCategoriesExtension(this HtmlHelper helper, int? CategoryID)
        {
            var list = new List<Category>();

            if (CategoryID != null)
            {
                list.Add(new CategoriesData().getCategorieByID(CategoryID));
            }
            else
                list = new CategoriesData().GetList();

            return list;
        }


        public static List<Employees> DisplayEmployeeExtension(this HtmlHelper helper, int? EmployeeID)
        {
            var list = new List<Employees>();

            if (EmployeeID != null)
            {
                list.Add(new EmployessData().getEmployeeByID(EmployeeID));
            }
            else
                list = new EmployessData().GetList();

            return list;
        }
         

        public static List<Customers> DisplayCustomerExtension(this HtmlHelper helper, int? CustomerID)
        {
            var list = new List<Customers>();

            if (CustomerID != null)
            {
                list.Add(new CustomersData().getCustomerById(CustomerID));
            }
            else
                list = new CustomersData().GetList();

            return list;
        }

        public static IHtmlString DisplayDateOrNull(this HtmlHelper helper, DateTime? date)
        {
            return new HtmlString(GetHtmlForDate(date));
        }
        private static string GetHtmlForDate(DateTime? date)
        {
            return date == null ? "<span>No Registrado</span>" : $"<span>{string.Format("{0:dd-MM-yyyy}", date)}</span>";
        }


    }
}