using BusinessObject;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exchange_Application.Controllers
{
    public class CurrencyController : Controller
    {
        // GET: Currency
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public ActionResult AddBillMaster(BillMasterView billMasterView)
        {
            BillMasteBL billMasteBL = new BillMasteBL();
            CustomMessage customMessage=   billMasteBL.AddBill(billMasterView);
            ViewBag.Message = customMessage.Message;


            return View("Index");
        }
    }
}