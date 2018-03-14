using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace ResistorCalculator.Models
{

    public class Color
    {
        [Required]
        public string selectedColorA { get; set; }
        [Required]
        public string selectedColorB { get; set; }
        [Required]
        public string selectedColorC { get; set; }
        [Required]
        public string selectedColorD { get; set; }
        public System.Web.Mvc.SelectList colors;
        public string resultString { get; set; }
    }
}