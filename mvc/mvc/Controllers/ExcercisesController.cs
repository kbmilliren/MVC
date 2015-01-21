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
        [HttpGet]
        public ActionResult FindLongestWord()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FindLongestWord(string text)
        {
            var wordinator = new Wordinator(text);
            var responseModel = new LongestWordViewModel
           {
               text = text,
               longest = wordinator.findLongestWord()

           };
            return View(responseModel);
        }
        [HttpGet]
        public ActionResult CountAlice()
        {
            return View();
        
        }
        [HttpPost]
        public ActionResult CountAlice(string text)
        {

            var wordinator = new Wordinator(text);

            var responseModel = new CountAliceViewModel
            {
                text = text,
                count = wordinator.countAlice()
            };
            
            return View(responseModel);
        }

    } 
    
}