using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class CategorieController : Controller
    {
        // GET: Categorie
        private CategoriesData _categorie = new CategoriesData();
        public ActionResult Index()
        {
            return View(_categorie.GetList());
        }
        

        public ActionResult Create()
        {
            return View(new Category());
        }

        [HttpPost]
        public ActionResult Create(Category categorie)
        {
            if (ModelState.IsValid)
            {
                _categorie.Add(categorie);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(_categorie.getCategorieByID(id));
        }

        [HttpPost]
        public ActionResult Edit(Category categorie)
        {
            if (ModelState.IsValid)
            {
                _categorie.Update(categorie);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var categorie = _categorie.getCategorieByID(id);
            if (categorie == null)
            {
                return RedirectToAction("Index");
            }
            return View(categorie);
        }

        [HttpPost]
        public ActionResult Delete(Category categorie)
        {
            if (_categorie.Delete(categorie) > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}