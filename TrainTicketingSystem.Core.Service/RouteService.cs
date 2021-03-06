﻿using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Repository.Interface;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.Core.Service
{
    public class RouteService : Service<Route>, IRouteService
    {
        public RouteService(IRepository<Route> repo) : base(repo)
        { }
    }
}