using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Axtract.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
            //return View("TempView/AliTempView.cshtml"); for other view
        }

        public ViewResult AboutUS()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
