using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingShop.Controllers
{
    public class CatalogController : Controller
    {
        // GET: CatalogController
        public ActionResult HomePage()
        {
            return View();
        }

        // GET: CatalogController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CatalogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: CatalogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}
