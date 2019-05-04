using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.App.Web.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IUserService userService;

        public DefaultController(IUserService userService)
        {
            this.userService = userService;
        }

        // GET: Default
        public ActionResult Index()
        {
            return RedirectToAction("PurchaseTicket");
        }

        [HttpGet]
        public ActionResult PurcaseTicket()
        {
            return View();
        }
    }
}