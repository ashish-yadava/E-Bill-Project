using EBill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EBill.Repository;

namespace EBill.Controllers
{
    public class EBillController : Controller
    {
        // GET: EBill
        public ActionResult Index()
        {
            Data data = new Data();
            var list = data.GetAllDetail();
            return View(list);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(BillDetail details)
        {
            Data data = new Data();
            ModelState.Clear();
            return View(details);
        }

        public ActionResult CreateItem(Items item)
        {
            return PartialView("_CreateItem",item);
        }
        public ActionResult ViewBill(int Id) 
        {
            Data data =new Data();
            var details = data.GetDetail(Id);
            return View(details);
        }
    }
}