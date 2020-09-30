using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppSastiServices.Models;
using WebAppSastiServices.Models.DB;
    

namespace WebAppSastiServices.Controllers
{
    public class AdminDashboardController : Controller
    {
        SastaServicesDBEntities db = new SastaServicesDBEntities();
        // GET: AdminDashboard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LatestActOrders()
        {
            List<TRNCustomerOrder> orders = db.TRNCustomerOrders.ToList<TRNCustomerOrder>();
            return Json(new { data =orders },JsonRequestBehavior.AllowGet);
        }


        public ActionResult Email()
        {
            return View();
        }
        public ActionResult Vendor()
        {
            return View();
        }
        //public ActionResult Supplier()
        //{
        //    return View();
        //}
        public ActionResult AdminProfile()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult LockScreen()
        {
            return View();
        }
        public ActionResult Invoice()
        {
            return View();
        }
        public ActionResult Maps()
        {
            return View();
        }
    }
}