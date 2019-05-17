using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainTicketingSystem.App.Web.Models;
using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.App.Web.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IUserService userService;
        private readonly IRouteService routeService;

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
            return View(new PurchaseTicketVM());
        }

        public JsonResult GetDestinationList(int id)
        {
            //Takes SourceId from FareQuery and PurchaseTicket Views' station from select list and
            //returns JSON data for station to select list
            List<Station> destinationList = routeService.GetDestinationsBySource(id).ToList();
            return Json(destinationList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult PurcaseTicket(PurchaseTicketVM model)
        {
            List<Station> sourceStations = routeService.GetAllSourceStations().ToList();
            ViewBag.SourceStations = sourceStations;
            if (ModelState.IsValid)
            {
                return RedirectToAction("Results");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult FareQuery()
        {
            List<Station> sourceStations = routeService.GetAllSourceStations().ToList();
            ViewBag.SourceStations = sourceStations;
            return View();
        }
    }
}
 