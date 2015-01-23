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

        public int factorial()
        {
            int n = 1;
            var fact = 1;
            for (int i = n; i > 1; i--)
                fact *= i;
            return fact;
        }


    }
   

}