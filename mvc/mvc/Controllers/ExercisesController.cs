using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class ExercisesController : Controller
    {
        [HttpGet]
        public ActionResult Sum()
        {
            return View();
        }

        [HttpPost]
        public ActionResult sum(string input)
        {
            List<int> numbers = new List<int>();

            foreach (var number in input.Split(','))
            {
                int t;
                if (Int32.TryParse(number, out t))
                {
                    numbers.Add(t);
                }
            }
            var thingy = new Mathinator(numbers.ToArray());

            var responseModel = new SumViewModel
            {
                numbers = thingy.numbers,
                sum = thingy.sum()
            }; 
            return View(responseModel);
        }


        [HttpGet]
        public ActionResult Multiply(MultiplyPostModel model)
        {
            return View();

        }

        [HttpPost]
        public ActionResult Multiply(string input)
        {

            List<int> numbers = new List<int>();

            foreach(var number in input.Split(',') )
            {
                int t;
                if (Int32.TryParse(number, out t))
                {
                    numbers.Add(t);
                }
            }


            var times = new Mathinator(numbers.ToArray());

            var responseModel = new MultiplyViewModel
            {
                numbers = times.numbers,
                multiply = times.multiply()
            };
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

        [HttpGet]
        public ActionResult Max()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Max(MaxPostModel model)
        {
            var math = new Mathinator(new[] { model.number1, model.number2, model.number3 });
            var responseModel = new MaxViewModel
            {
                numbers = math.numbers,
                max = math.Max()
            };

            return View(responseModel);
        }

        [HttpGet]
        public ActionResult wordFrequency()
        {
            return View();
        }

        [HttpPost]
        public ActionResult wordFrequency(string text)
        {
            var wordinator = new Wordinator(text);
            var responseModel = new WordFrequencyViewModel();
            responseModel.text = text;
            responseModel.frequencies = wordinator.WordFrequency();

            return View(responseModel);
        }

        [HttpGet]
        public ActionResult factorial()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult factorial(int num)
            {
                var responseModel = new FactorialViewModel
            {
                number = num,
                factorial = Mathinator.factorial(num)

            };
            return View(responseModel);
        }

        [HttpGet]
        public ActionResult palindrome()
        {
            return View();

        }
        [HttpPost]
        public ActionResult palindrome(string text)
        {

            var pal = new Wordinator(text);

            var responseModel = new PalindromeViewModel
            {
                text = text,
                palindrome = pal.palindrome(text)
            };

            return View(responseModel);
        }
        [HttpGet]
        public ActionResult printNumbers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult printNumbers(int num1, int num2)
        {
           var responseModel = new NumbersViewModel();
           responseModel.num1 = num1;
           responseModel.num2 = num2;
           responseModel.output = Mathinator.printNumbers(num1, num2);

      
           return View(responseModel);
        }

        [HttpGet]
        public ActionResult perfectNumber()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult perfectNumber(int num1)
        {
            var responseModel = new PerfectViewModel();
            responseModel.num1 = num1;
            responseModel.result = Mathinator.perfectNumber(num1);

            return View(responseModel);
        }*/

        [HttpGet]
        public ActionResult filterLongstWord()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult filterLongestWord(string text, int i)
        {
            var wordinator = new Wordinator(text);
            var responseModel = new FilterViewModel();
            responseModel.i = i;
            responseModel.text = wordinator.filterLongestWord(i);

            return View(responseModel);
        }*/

        }
 }  


    
 
 
