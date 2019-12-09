using TrainTicketingSystem.Core.Repository.Interface;
using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.Core.Service
{
    public class TicketSeatService : Service<TicketSeat>, ITicketSeatService
    {
        public TicketSeatService(IRepository<TicketSeat> repo) : base(repo)
        { }
    }
}
