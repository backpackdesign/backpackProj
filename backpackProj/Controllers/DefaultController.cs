using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using backpackProj.Models.classes;
using System.Web.Mvc;

namespace backpackProj.Controllers
{
    public class DefaultController : Controller
    {  
        public ActionResult Index()
        {
            
            
            return View();
        }
        public ActionResult About()
        {

            return View();
        }
        
    }
}