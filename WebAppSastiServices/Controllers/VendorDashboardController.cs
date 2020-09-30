using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppSastiServices.Models;
using WebAppSastiServices.Models.DB;

namespace WebAppSastiServices.Controllers
{
    public class VendorDashboardController : Controller
    {
        SastaServicesDBEntities db = new SastaServicesDBEntities();
        //------Generators start--------------
        public ActionResult GeneratorsIndex()
        {
            return View();
        }


        public ActionResult GeneratorsEmail()
        {
            return View();
        }
        public ActionResult GeneratorsProfile()
        {
            return View();
        }
        public ActionResult GeneratorsInvoice()
        {
            return View();
        }
        public ActionResult GeneratorsLogin()
        {
            return View();
        }
        public ActionResult GeneratorsRegister()
        {
            return View();
        }
        public ActionResult GeneratorsLockScreen()
        {
            return View();
        }
        public ActionResult GeneratorsViewServices()
        {
            return View();
        }
        public ActionResult GeneratorsCreateServices()
        {
            return View();
        }
        public ActionResult GeneratorsEditServices()
        {
            return View();
        }
        public ActionResult GeneratorsDeleteServices()
        {
            return View();
        }
        
        public ActionResult GeneratorsViewItems()
        {
            return View();
        }
        public ActionResult GeneratorsCreateItems()
        {
            return View();
        }
        public ActionResult GeneratorsEditItems()
        {
            return View();
        }
        public ActionResult GeneratorsDeleteItems()
        {
            return View();
        }
        //------Generators end


        //------AC start--------------
        // GET: VendorDashboard
        public ActionResult ACIndex()
        {
            return View();
        }
        public ActionResult pvACLatestActOrders()
        {

            var Orders = (from d in db.STPOrders
                          where d.STPStatu.Description == "Active" && d.STPServiceType.ServiceTypeName== "Air Condition"
                            select d).ToList();
            return View(Orders);
        }


        public ActionResult ACEmail()
        {
            return View();
        }
        public ActionResult ACProfile()
        {
            return View();
        }
        public ActionResult ACInvoice()
        {
            return View();
        }
        public ActionResult ACLogin()
        {
            return View();
        }
        public ActionResult ACRegister()
        {
            return View();
        }
        public ActionResult ACLockScreen()
        {
            return View();
        }
        public ActionResult ACViewServices()
        {
            return View();
        }
        public ActionResult ACCreateServices()
        {
            return View();
        }
        public ActionResult ACEditServices()
        {
            return View();
        }
        public ActionResult ACDeleteServices()
        {
            return View();
        }

        public ActionResult ACViewItems()
        {
            return View();
        }
        public ActionResult ACCreateItems()
        {
            return View();
        }
        public ActionResult ACEditItems()
        {
            return View();
        }
        public ActionResult ACDeleteItems()
        {
            return View();
        }
        //------AC end

        
        //------CCTV start--------------
        // GET: VendorDashboard
        public ActionResult CCTVIndex()
        {
            return View();
        }


        public ActionResult CCTVEmail()
        {
            return View();
        }
        public ActionResult CCTVProfile()
        {
            return View();
        }
        public ActionResult CCTVInvoice()
        {
            return View();
        }
        public ActionResult CCTVLogin()
        {
            return View();
        }
        public ActionResult CCTVRegister()
        {
            return View();
        }
        public ActionResult CCTVLockScreen()
        {
            return View();
        }
        public ActionResult CCTVViewServices()
        {
            return View();
        }
        public ActionResult CCTVCreateServices()
        {
            return View();
        }
        public ActionResult CCTVEditServices()
        {
            return View();
        }
        public ActionResult CCTVDeleteServices()
        {
            return View();
        }

        public ActionResult CCTVViewItems()
        {
            return View();
        }
        public ActionResult CCTVCreateItems()
        {
            return View();
        }
        public ActionResult CCTVEditItems()
        {
            return View();
        }
        public ActionResult CCTVDeleteItems()
        {
            return View();
        }
        //-----CCTV end

        //------SolarSys start--------------
        // GET: VendorDashboard
        public ActionResult SolarSysIndex()
        {
            return View();
        }


        public ActionResult SolarSysEmail()
        {
            return View();
        }
        public ActionResult SolarSysProfile()
        {
            return View();
        }
        public ActionResult SolarSysInvoice()
        {
            return View();
        }
        public ActionResult SolarSysLogin()
        {
            return View();
        }
        public ActionResult SolarSysRegister()
        {
            return View();
        }
        public ActionResult SolarSysLockScreen()
        {
            return View();
        }
        public ActionResult SolarSysViewServices()
        {
            return View();
        }
        public ActionResult SolarSysCreateServices()
        {
            return View();
        }
        public ActionResult SolarSysEditServices()
        {
            return View();
        }
        public ActionResult SolarSysDeleteServices()
        {
            return View();
        }

        public ActionResult SolarSysViewItems()
        {
            return View();
        }
        public ActionResult SolarSysCreateItems()
        {
            return View();
        }
        public ActionResult SolarSysEditItems()
        {
            return View();
        }
        public ActionResult SolarSysDeleteItems()
        {
            return View();
        }
        //-----SolarSys end
        //------UPS start--------------
        // GET: VendorDashboard
        public ActionResult UPSIndex()
        {
            return View();
        }


        public ActionResult UPSEmail()
        {
            return View();
        }
        public ActionResult UPSProfile()
        {
            return View();
        }
        public ActionResult UPSInvoice()
        {
            return View();
        }
        public ActionResult UPSLogin()
        {
            return View();
        }
        public ActionResult UPSRegister()
        {
            return View();
        }
        public ActionResult UPSLockScreen()
        {
            return View();
        }
        public ActionResult UPSViewServices()
        {
            return View();
        }
        public ActionResult UPSCreateServices()
        {
            return View();
        }
        public ActionResult UPSEditServices()
        {
            return View();
        }
        public ActionResult UPSDeleteServices()
        {
            return View();
        }

        public ActionResult UPSViewItems()
        {
            return View();
        }
        public ActionResult UPSCreateItems()
        {
            return View();
        }
        public ActionResult UPSEditItems()
        {
            return View();
        }
        public ActionResult UPSDeleteItems()
        {
            return View();
        }
        //-----UPS end




        public ActionResult Print()
        {
            return View();
        }


    }
}