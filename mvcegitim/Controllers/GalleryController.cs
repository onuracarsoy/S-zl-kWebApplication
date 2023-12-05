using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcegitim.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        ImageFileManager ifm = new ImageFileManager(new EFImageFileDal());
    
        public ActionResult Index()
        {
            var files = ifm.GetList();
            return View(files);
        }
    }
}