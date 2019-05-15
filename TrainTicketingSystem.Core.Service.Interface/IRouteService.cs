﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTicketingSystem.Core.Domain;

namespace TrainTicketingSystem.Core.Service.Interface
{
    public interface IRouteService : IService<Route>
    {
        IEnumerable<Station> GetAllSourceStations();
        IEnumerable<Station> GetDestinationsBySource(int sourceId);
    }
}
