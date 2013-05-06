using System.Web.Mvc;
using EFDemo.Service.Interfaces;

namespace EFDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICatalogService _service;

        public HomeController(ICatalogService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            ViewData.Model = _service.GetCategories();
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
