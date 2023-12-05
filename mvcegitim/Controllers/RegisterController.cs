using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
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
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterDal());
        WriterValidator writervalidator = new WriterValidator();
    
        // GET: Register



        [HttpGet]
        public ActionResult WriterRegister()
        {



            return View();
        }

        [HttpPost]
        public ActionResult WriterRegister(Writer p)
        {
    
                p.WriterAbout = "Default";
                p.WriterStatus = true;
                p.WriterImage = "Default";
                p.WriterTitle="Default";    

                wm.WriterAdd(p);
                return RedirectToAction("WriterLogin","Login");
            }

    
        }
    }