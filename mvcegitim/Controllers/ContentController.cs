using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcegitim.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content

        ContentManager cm = new ContentManager(new EFContentDal());
       
        public ActionResult Index()
        {
            return View();
        }
    
        public ActionResult GetAllContent(string p)
        {
            if (p == null)
            {
                var values = cm.GetList();
                return View(values.ToList());
            }
            else
            {
                var values = cm.GetList(p);
                return View(values);
            }
        }

        public ActionResult ContentbyHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);

            return View(contentvalues);
        }
    }
}