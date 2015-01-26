using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class Mathinator
    {
        public int[] numbers { get; set; }

        public Mathinator(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int Max()
        {
            int largest = 0;
            foreach(var number in numbers)
               {
                   if (number > largest)
                        largest = number;

               }
            return largest;
        }

        public int sum()
        {
            int sum = 0;
            foreach (var number in numbers)
                sum += number;
            return sum;
        }
        
        
        public int multiply()
        
        {
            int multiply = 1;
            foreach (var number in numbers)
                multiply *= number;
            return multiply;
        }

        public static int factorial(int n)
        {
            
            var fact = 0;
            for (int i = n; i > 1; i--)
                fact *= i;
            return fact;
        }

        public string printNumbers(int a, int b)
        {
            var output = "";
            for (var counter = a; counter <= b && (counter - a <= 100); counter++)
            {
                if (counter % 15 == 0)
                    output += "fizzbuzz<br />";
                else if (counter % 3 == 0)
                    output += "fizz<br />";
                else if (counter % 5 == 0)
                    output += "buzz<br />";
                else
                    output += counter + "<br />";
            }
            return output;
            
        }
    }
   

}