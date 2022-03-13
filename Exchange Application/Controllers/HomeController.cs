using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessObject;
using BusinessLogic;

namespace Exchange_Application.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Login(UserView userView)
        {
            CustomMessage customMessage = new CustomMessage();
            try
            {

                UserBL UBl = new UserBL();
                customMessage = UBl.Login(userView);
                if (customMessage.Value > 0)
                {
                    MenuBL menu = new MenuBL();
                    customMessage = menu.UserMenu(customMessage.Value);
                    
                }
                else
                {
                    return View("Index");
                }
                TempData["MSG"] = customMessage.Message;
            }
            catch(Exception ex)
            {
                TempData["MSG"] = customMessage.Message;
                return View("Index");
            }

            return RedirectToAction("DashBoard");


        }
        public ActionResult DashBoard()
        {
            return View();
        }
        public ActionResult MenuPartials()
        {
            return View();
        }

    }
}