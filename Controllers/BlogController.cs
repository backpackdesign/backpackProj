using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using backpackProj.Models.classes;
namespace backpackProj.Controllers
{
    public class BlogController : Controller
    {
       
        public ActionResult Index()
        {
            
            return View();
        }
        
        public ActionResult BlogDetay(int id)
        {
          
            return View();
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
           
            return PartialView();
        }
    }
}