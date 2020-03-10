using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Userregistration.Models;
namespace Userregistration.Controllers
{
    public class UserController : Controller
    {
      [HttpGet]
        public ActionResult ADDorEdit(int id = 0)
        {
            Userlog user = new Userlog();
            return View(user);
        }

        [HttpPost]
      public ActionResult ADDorEdit(Userlog usermodel)
      {  using (AppDBEntities apmodel = new AppDBEntities()){
          if (apmodel.Userlogs.Any(x => x.Username == usermodel.Username)){
              ViewBag.DuplicateMessage = "Already exist";
              return View("ADDorEdit",usermodel);


          }
          apmodel.Userlogs.Add(usermodel);
          apmodel.SaveChanges();
            }
      ModelState.Clear();
      ViewBag.sucessMessage = "Registration Completed";
      return View("ADDorEdit", new Userlog());

      }

        public ActionResult login()
        {
            return View();
        }
    
    }
}