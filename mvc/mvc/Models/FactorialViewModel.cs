using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class FactorialViewModel
    {
        public int[] number { get; set; }
        public int factorial { get; set; }
    }

    public class FactorialPostModel
    {
        public int[] number { get; set; }
    }
}