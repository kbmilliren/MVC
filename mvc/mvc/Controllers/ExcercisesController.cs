using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class ExcercisesController : Controller
    {
        [HttpGet]
        public ActionResult Sum()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sum(SumPostModel model)
        {
            var responseModel = new SumViewModel
            {
                number1 = model.number1,
                number2 = model.number2

            }; 
                responseModel.SetSum();
              
                return View(responseModel);
        }
    } 
    
}