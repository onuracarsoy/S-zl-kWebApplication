using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcegitim.Controllers
{
   
    public class HomeController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageDal());
        MessageValidator messagevalidator = new MessageValidator();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();

        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {

            ValidationResult results = messagevalidator.Validate(p);
            if (results.IsValid)
            {
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mm.MessageAdd(p);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }



            return View();

        }

        [AllowAnonymous]
        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [AllowAnonymous]
        public ActionResult HomePage()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Information()
        {
            return View();
        }


    }
}