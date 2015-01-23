﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class SumViewModel
    {
        public int[] numbers { get; set; }
        public int sum { get; set; }
    }
    
    public class SumPostModel
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int number3 { get; set; }
    }
}