
using Insurance.Models;
using Insurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var UserInput = (from c in db.UserInputs
                                 where c.Removed == null
                                 select c).ToList();
                var userVms = new List<UserInputVm>();
                foreach (var user in UserInput)
                {
                    var userVm = new UserInputVm();
                    userVm.Id = user.Id;
                    userVm.FirstName = user.FirstName;
                    userVm.LastName = user.LastName;
                    userVm.EmailAddress = user.EmailAddress;
                    userVms.Add(userVm);

                }
                return View(userVms);
            }
        }
    }
}