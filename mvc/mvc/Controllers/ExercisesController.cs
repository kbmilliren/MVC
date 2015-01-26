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
            var responseModel = new WordFrequencyViewModel
            {
                text = text,
                frequencies = wordinator.WordFrequency()
            };
            return View(responseModel);
        }

        [HttpGet]
        public ActionResult factorial()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult factorial(int model)
            {
                var mathinator = new Mathinator(new[] { model });
                var responseModel = new FactorialViewModel
            {
                number = mathinator.numbers,
                factorial = mathinator.factorial()

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
                palindrome = pal.palindrome()
            };

            return View(responseModel);
        }
        [HttpGet]
        public ActionResult printNumbers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult printNumbers(int model)
        {
            var mathinator = new Mathinator(new[] { model });
            var responseModel = new NumbersViewModel
            {
                number = mathinator.numbers,
                output = mathinator.printNumbers()

            };
            return View(responseModel);
        }
    }
 
 }
    
