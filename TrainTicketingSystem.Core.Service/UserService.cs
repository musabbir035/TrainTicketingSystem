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
    public class UserService : Service<User>, IUserService
    {
        public UserService(IRepository<User> repo) : base(repo)
        {
        }

        public User GetUserByEmail(string email)
        {
            return GetAll().Where(e => e.Email == email).SingleOrDefault();
        }

        public bool UserLogin(string email, string password)
        {
            User user = new User();
            try
            {
                user = GetUserByEmail(email);
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong.");
            }

            if (user == null)
            {
                throw new Exception("No user found with your provided email.");
            }
            else if (user.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UserRegister(User user)
        {
            try
            {
                if (GetUserByEmail(user.Email) == null)
                {
                    Insert(user);
                    return true;
                }
                else
                {
                    throw new Exception("Email already in use.");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong! Error message = " + e.Message);
            }
        }

        public string ChangePassword(string email, string currentPassword, string newPassword, string repeatNewPassword)
        {
            if (newPassword.Length < 6 || newPassword.Length > 100)
            {
                return "Password length must be between 6 & 100 characters.";
            }
            else if (currentPassword == newPassword)
            {
                return "New password is same as old password. Please enter a new one.";
            }
            else if (newPassword == repeatNewPassword)
            {
                User user = new User();
                try
                {
                    user = GetUserByEmail(email);
                }
                catch (Exception e)
                {
                    return "Something went wrong.";
                }

                if (currentPassword == user.Password)
                {
                    try
                    {
                        user.Password = newPassword;
                        Update(user);
                        repo.Save();
                        return "Password changed succesfully.";
                    }
                    catch (Exception e)
                    {
                        return "Something went wrong.";
                    }
                }
                else
                {
                    return "Wrong current password.";
                }
            }
            else
            {
                return "New passwords do not match.";
            }
        }
    }
}
