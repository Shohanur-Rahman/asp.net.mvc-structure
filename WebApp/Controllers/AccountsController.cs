using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Constant;
using WebApp.Helper;

namespace WebApp.Controllers
{
    public class AccountsController : Controller
    {
        private UserRepository _repository;
        public AccountsController()
        {
            _repository = new UserRepository();
        }
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            var users = _repository.GetUsers();
            ViewBag.Users = users.Data;
            return View();
        }

        [HttpPost]
        public ActionResult Register(USERS model)
        {
            if (ModelState.IsValid)
            {
               var result = _repository.SaveUser(model);
                if(result.IsSuccess == true)
                {
                    MessageHelper.SuccessMeesage(this,true, VWResponseMessage.REGISTRATION_MESSAGE);
                    return RedirectToAction("Login");
                }
                {
                    MessageHelper.SuccessMeesage(this, true, result.Message);
                    return View();
                }
            }
            return View();
        }
    }
}