using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Repository.Interface;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.Core.Service
{
    public class StationService : Service<Station>, IStationService
    {
        public StationService(IRepository<Station> repo) : base(repo)
        { }
    }
}
