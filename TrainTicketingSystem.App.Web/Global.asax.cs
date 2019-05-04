using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TrainTicketingSystem.App.Web.App_Start;
using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Repository;
using TrainTicketingSystem.Core.Repository.Interface;
using TrainTicketingSystem.Core.Service;
using TrainTicketingSystem.Core.Service.Interface;
using Unity;
using Unity.AspNet.Mvc;
using Route = TrainTicketingSystem.Core.Domain.Route;

namespace TrainTicketingSystem.App.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterBundles(BundleTable.Bundles);
            BundleTable.EnableOptimizations = true;

            IUnityContainer container = new UnityContainer();
            container.RegisterType<DbContext, TrainDbContext>();
            container.RegisterType<IRepository<User>, Repository<User>>();
            container.RegisterType<IRepository<Train>, Repository<Train>>();
            container.RegisterType<IRepository<Ticket>, Repository<Ticket>>();
            container.RegisterType<IRepository<Route>, Repository<Route>>();
            container.RegisterType<IRepository<Station>, Repository<Station>>();
            container.RegisterType<IUserService, UserService>();
            /*container.RegisterType<ITicketService, TicketService>();
            container.RegisterType<IRouteService, RouteService>();
            container.RegisterType<IStationService, StationService>();
            container.RegisterType<ITrainService, TrainService>();*/

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
