using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TrainTicketingSystem.App.Web.Models;
using TrainTicketingSystem.Core.Domain;
using TrainTicketingSystem.Core.Domain.Custom_Models;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.App.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [Authorize]
        public ActionResult Index()
        {
            User user = userService.GetUserByEmail(System.Web.HttpContext.Current.User.Identity.Name);
            //List<Ticket> tickets = ticketService.GetTicketsByUserEmail(user.Email).ToList();
            IndexVM model = new IndexVM
            {
                User = user,
                Tickets = null,
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (HttpContext.Request.IsAuthenticated)
            {
                return RedirectToAction("Index");
            }
            return View(new LoginVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ErrorHandler handler = userService.UserLogin(model.Email, model.Password);
                    if (!handler.IsError)
                    {
                        FormsAuthentication.SetAuthCookie(model.Email, false);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Error = handler.Message;
                        ViewBag.Exception = handler.ExceptionMessage;
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.Error = "Something went wrong! We are Sorry for your inconvenience.";
                ViewBag.Exception = e.Message;
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Register()
        {
            if (HttpContext.Request.IsAuthenticated)
            {
                return RedirectToAction("Index");
            }
            return View(new RegisterVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    User user = new User
                    {
                        Email = model.Email,
                        Password = model.Password,
                        Name = model.Name,
                        MobileNo = model.MobileNo,
                        JoinDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                    };
                    ErrorHandler handler = userService.UserRegister(user);
                    if (!handler.IsError)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Error = handler.Message;
                        ViewBag.Exception = handler.ExceptionMessage;
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.Error = "Something Went wrong! We are Sorry for your inconvenience.";
                ViewBag.Exception = e.Message;
            }
            return View(model);
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}