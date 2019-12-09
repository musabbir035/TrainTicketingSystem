using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Repository.Interface;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.Core.Service
{
    public class UserService : Service<User>, IUserService
    {
        public UserService(IRepository<User> repo) : base(repo)
        { }
    }
}
