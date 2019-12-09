using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Repository.Interface;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.Core.Service
{
    class PasswordResetService : Service<PasswordReset>, IPasswordResetService
    {
        public PasswordResetService(IRepository<PasswordReset> repo) : base(repo)
        { }
    }
}