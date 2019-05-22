using TrainTicketingSystem.Core.Domain;

namespace TrainTicketingSystem.Core.Service.Interface
{
    public interface IUserService : IService<User>
    {
        User GetUserByEmail(string email);
        bool UserLogin(string email, string password);
        bool UserRegister(User user);
        string ChangePassword(string email, string currentPassword, string newPassword, string repeatNewPassword);
    }
}
