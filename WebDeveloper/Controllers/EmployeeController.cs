using System.Web.Mvc;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;

namespace WebDeveloper.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employe
        private EmployessData _employee = new EmployessData();
        public ActionResult Index()
        {
            return View(_employee.GetList());
        }

        public ActionResult Create() {
            return View(new Employees());
        }

        [HttpPost]
        public ActionResult Create(Employees employee)
        {
            if (ModelState.IsValid)
            {
                _employee.Add(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int? id=0)
        {
            Employees employee = new Employees();
            employee = _employee.getEmployeeByID(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employees employee) {
            //var employee = _employee.getEmployeeByID(id);
            if (ModelState.IsValid)
            {
                _employee.Update(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int? id)
        {
            return View(_employee.getEmployeeByID(id));
        }

        [HttpPost]
        public ActionResult Delete(Employees employee)
        {
            //var employee = _employee.getEmployeeByID(id);

            if (_employee.Delete(employee) > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}