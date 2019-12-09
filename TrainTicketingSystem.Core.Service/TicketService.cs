using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Repository.Interface;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.Core.Service
{
    public class TicketService : Service<Ticket>, ITicketService
    {
        public TicketService(IRepository<Ticket> repo) : base(repo)
        { }
    }
}