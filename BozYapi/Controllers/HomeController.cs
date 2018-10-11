using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BozYapi.Models;
using BozYapi.Data;


namespace BozYapi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            tbl_Images images = new tbl_Images();


            ViewBag.Contact = Data.Data.get_Contact(1);

            ViewBag.Services = Data.Data.get_Services(1);

            ViewBag.Aboutus = Data.Data.get_Aboutus(1);

            ViewBag.Images = Data.Data.get_Images();
            return View();

            
        }
    }
}