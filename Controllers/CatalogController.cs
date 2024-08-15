using Microsoft.AspNetCore.Mvc;

namespace GamingShop.Controllers
{
    public class CatalogController : Controller
    {

        public ActionResult HomePage()
        {
            return View();
        }
    }
}
