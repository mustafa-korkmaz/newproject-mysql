using System.Web.Mvc;
using Business.WebApi;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            //new ContextCreator().CreateDb(); // create db if not exists
            //todo: delete this method in release

            return View();
        }
    }
}
