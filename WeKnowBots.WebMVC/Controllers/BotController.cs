using Microsoft.AspNet.Identity;
using System;
using System.Web.Mvc;
using WeKnowBots.Models;
using WeKnowBots.Services;

namespace WeKnowBots.WebMVC.Controllers
{
    [Authorize]
    public class BotController : Controller
    {
        // GET: Bot
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new BotServices(userId);
            var model = service.GetAllBots();

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
            if (!ModelState.IsValid) return View(model);

            var service = CreateBotService();

            if (service.CreateBot(model))
            {
                ViewBag.SaveResult = "Your bot has been created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Your could not be created.");

            return View(model);
        }

        public BotServices CreateBotService()
        {
            var id = Guid.Parse(User.Identity.GetUserId());
            BotServices service = new BotServices(id);
            return service;
        }

    }
}