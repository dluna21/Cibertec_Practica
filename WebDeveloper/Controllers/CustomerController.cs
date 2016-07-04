using System.Web.Mvc;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;

namespace WebDeveloper.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private CustomersData _customer = new CustomersData();
        public ActionResult Index()
        {
            return View(_customer.GetList());
        }

        public ActionResult Create() {
            return View(new Customers());
        }

        [HttpPost]
        public ActionResult Create(Customers customer) {
            if (ModelState.IsValid)
            {
                _customer.Add(customer);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(_customer.getCustomerById(id));
        }

        [HttpPost]
        public ActionResult Edit(Customers customer)
        {
            if (ModelState.IsValid)
            {
                _customer.Update(customer);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var customer = _customer.getCustomerById(id);
            if(customer == null)
            {
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        [HttpPost]
        public ActionResult Delete(Customers customer)
        {
            if (_customer.Delete(customer)>0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}