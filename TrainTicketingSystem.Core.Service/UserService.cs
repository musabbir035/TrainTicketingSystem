using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Domain.Custom_Models;
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

        public ErrorHandler UserLogin(string email, string password)
        {
            User user = new User();
            try
            {
                user = GetUserByEmail(email);
                if (user == null)
                {
                    return new ErrorHandler
                    {
                        IsError = true,
                        Message = "No user found with the provided email.",
                        ExceptionMessage = null
                    };
                }
                else if (user.Password == password)
                {
                    return new ErrorHandler
                    {
                        IsError = false,
                        Message = null,
                        ExceptionMessage = null
                    };
                }
                else
                {
                    return new ErrorHandler
                    {
                        IsError = true,
                        Message = "Email and password does not match.",
                        ExceptionMessage = null
                    };
                }
            }
            catch (Exception e)
            {
                return new ErrorHandler
                {
                    IsError = true,
                    Message = "Something went wrong! We are Sorry for your inconvenience.",
                    ExceptionMessage = e.Message
                };
            }
        }

        public ErrorHandler UserRegister(User user)
        {
            try
            {
                if (GetUserByEmail(user.Email) == null)
                {
                    Insert(user);
                    return new ErrorHandler
                    {
                        IsError = false,
                        Message = null,
                        ExceptionMessage = null
                    };
                }
                else
                {
                    return new ErrorHandler
                    {
                        IsError = true,
                        Message = "Email already in use.",
                        ExceptionMessage = null
                    };
                }
            }
            catch (Exception e)
            {
                return new ErrorHandler
                {
                    IsError = true,
                    Message = "Something went wrong! We are Sorry for your inconvenience.",
                    ExceptionMessage = e.Message
                };
            }
        }

        public ErrorHandler ChangePassword(string email, string currentPassword, string newPassword, string repeatNewPassword)
        {
            if (newPassword.Length < 6 || newPassword.Length > 100)
            {
                return new ErrorHandler
                {
                    IsError = true,
                    Message = "Password length must be between 6 & 100 characters.",
                    ExceptionMessage = null
                };
            }
            else if (currentPassword == newPassword)
            {
                return new ErrorHandler
                {
                    IsError = true,
                    Message = "New password is same as old password. Please enter a new one.",
                    ExceptionMessage = null
                };
            }
            else if (newPassword == repeatNewPassword)
            {
                User user = new User();
                try
                {
                    user = GetUserByEmail(email);
                    if (currentPassword == user.Password)
                    {
                        user.Password = newPassword;
                        Update(user);
                        repo.Save();
                        return new ErrorHandler
                        {
                            IsError = false,
                            Message = "Password changed succesfully.",
                            ExceptionMessage = null
                        };
                    }
                    else
                    {
                        return new ErrorHandler
                        {
                            IsError = true,
                            Message = "Wrong current password.",
                            ExceptionMessage = null
                        };
                    }
                }
                catch (Exception e)
                {
                    return new ErrorHandler
                    {
                        IsError = true,
                        Message = "Something went wrong! We are Sorry for your inconvenience.",
                        ExceptionMessage = e.Message
                    };
                }
            }
            else
            {
                return new ErrorHandler
                {
                    IsError = true,
                    Message = "New passwords do not match.",
                    ExceptionMessage = null
                };
            }
        }
    }
}
