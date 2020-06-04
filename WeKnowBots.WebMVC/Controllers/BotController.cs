using System.Web.Mvc;
using WeKnowBots.Models;

namespace WeKnowBots.WebMVC.Controllers
{
    [Authorize]
    public class BotController : Controller
    {
        // GET: Bot
        public ActionResult Index()
        {
            var model = new BotListItem[0];
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BotCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}