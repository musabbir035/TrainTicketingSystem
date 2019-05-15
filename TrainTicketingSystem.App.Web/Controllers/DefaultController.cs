using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.App.Web.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IUserService userService;
        private IRouteService routeService;

        public DefaultController(IUserService userService, IRouteService routeService)
        {
            this.userService = userService;
            this.routeService = routeService;
        }

        // GET: Default
        public ActionResult Index()
        {
            return RedirectToAction("PurchaseTicket");
        }

        [HttpGet]
        public ActionResult PurcaseTicket()
        {
            List<Station> sourceStations = routeService.GetAllSourceStations().ToList();
            ViewBag.SourceStations = sourceStations;
            return View();
        }

        public JsonResult GetDestinationList(int id)
        {
            //Takes SourceId from FareQuery View's station from select list and
            //returns JSON data for station to select list
            List<Station> destinationList = routeService.GetDestinationsBySource(id).ToList();
            return Json(destinationList, JsonRequestBehavior.AllowGet);
        }
    }
}
 