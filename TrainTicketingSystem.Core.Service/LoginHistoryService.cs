using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Repository.Interface;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.Core.Service
{
    class LoginHistoryService : Service<LoginHistory>, ILoginHistoryService
    {
        public LoginHistoryService(IRepository<LoginHistory> repo) : base(repo)
        { }
    }
}