using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Repository.Interface;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.Core.Service
{
    public class RouteService : Service<Route>, IRouteService
    {
        private IStationService stationService;

        public RouteService(IRepository<Route> repo, IStationService stationService) : base(repo)
        {
            this.stationService = stationService;
        }

        public IEnumerable<Station> GetAllSourceStations()
        {
            return stationService.GetAll().Join(GetAll(), e => e.Id, f => f.SourceId, (e, f) => e).Distinct();
        }

        public IEnumerable<Station> GetDestinationsBySource(int sourceId)
        {
            return stationService.GetAll().Join(GetAll(), e => e.Id, f => f.DestinationId, (e, f) => new { e = e, f = f }).Where(temp0 => (temp0.f.SourceId == sourceId)).Select(temp0 => temp0.e).Distinct();
        }
    }
}
