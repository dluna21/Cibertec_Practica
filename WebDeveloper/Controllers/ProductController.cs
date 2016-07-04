using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private ProductsData _product = new ProductsData();
        private CategoriesData _categoria = new CategoriesData();

        public ActionResult Index()
        {
            return View(_product.GetList());
        }

        public ActionResult Create()
        {
            return View(new Products());
        }
        [HttpPost]
        public ActionResult Create(Products product)
        {
            if (ModelState.IsValid)
            {
                //Validamos que exista una categoria valida para ingresar el producto
                if(_categoria.getCategorieByID(product.CategoryID)!=null) { 
                    _product.Add(product);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(_product.getProductById(id));
        }

        [HttpPost]
        public ActionResult Edit(Products product)
        {
            if (ModelState.IsValid)
            {
                _product.Update(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View(_product.getProductById(id));
        }
        [HttpPost]
        public ActionResult Delete(Products product)
        {
            if (_product.Delete(product) > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}