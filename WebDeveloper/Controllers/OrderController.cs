using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        private OrdersData _order = new OrdersData();
        public ActionResult Index()
        {
            return View(_order.GetList());
        }

        public ActionResult Create()
        {
            return View(new Orders());
        }

        [HttpPost]
        public ActionResult Create(Orders order)
        {
            if (ModelState.IsValid)
            {
                _order.Add(order);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(_order.getOrderByID(id));
        }

        [HttpPost]
        public ActionResult Edit(Orders order)
        {
            if (ModelState.IsValid)
            {
                _order.Update(order);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var order = _order.getOrderByID(id);
            if (order == null)
            {
                return RedirectToAction("Index");
            }
            return View(order);
        }

        [HttpPost]
        public ActionResult Delete(Orders order)
        {
            if (_order.Delete(order) > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
