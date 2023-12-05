using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.Ajax.Utilities;
using mvcegitim.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcegitim.Controllers
{
    public class ChartController : Controller
    {
       
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryChart()
        {

            return Json(BlogList(), JsonRequestBehavior.AllowGet);

        }



        public List<CategoryClass> BlogList()
        {
         
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()

            {

                CategoryName = "Tiyatro",
                CategoryCount = 8

            }) ;

            ct.Add(new CategoryClass()
            {
                CategoryName = "Eğitim",
                CategoryCount = 4

            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Kitap",
                CategoryCount = 7

            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Spor",
                CategoryCount = 1

            });

            return ct;


        }
    }
}