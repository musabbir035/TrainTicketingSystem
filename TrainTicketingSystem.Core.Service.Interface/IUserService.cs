using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Domain.Custom_Models;

namespace TrainTicketingSystem.Core.Service.Interface
{
    public interface IUserService : IService<User>
    {
        User GetUserByEmail(string email);
        ErrorHandler UserLogin(string email, string password);
        ErrorHandler UserRegister(User user);
        ErrorHandler ChangePassword(string email, string currentPassword, string newPassword, string repeatNewPassword);
    }
}
