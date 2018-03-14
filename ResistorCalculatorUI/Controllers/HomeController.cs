using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResistorCalculator.Models;
using ElectronicRatingCalculatorComponent;
using System.Text;

namespace ResistorCalculator.Controllers
{
    
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                 new SelectListItem(){Value="Silver", Text= "Silver"},
                 new SelectListItem(){Value="Gold"  , Text= "Gold"  },
                 new SelectListItem(){Value="Black" , Text= "Black" },
                 new SelectListItem(){Value="Brown" , Text= "Brown" },
                 new SelectListItem(){Value="Red"   , Text= "Red"   },
                 new SelectListItem(){Value="Orange", Text= "Orange"},
                 new SelectListItem(){Value="Yellow", Text= "Yellow"},
                 new SelectListItem(){Value="Green" , Text= "Green" },
                 new SelectListItem(){Value="Blue"  , Text= "Blue"  },
                 new SelectListItem(){Value="Violet", Text= "Violet"},
                 new SelectListItem(){Value="Gray"  , Text= "Gray"  },
                 new SelectListItem(){Value="White" , Text= "White" }

            };


            var colorModel = new Color();
            colorModel.colors = new SelectList(list, "Value", "Text");


            return View(colorModel);
        }



        [HttpPost]
        public ActionResult GetOhm(Color colorModel)
        {

            OhmValueCalculator ohmCalculator = new OhmValueCalculator();
           
            Tuple<double, double> result = ohmCalculator.CalculateOhmValue(colorModel.selectedColorA,
                colorModel.selectedColorB, colorModel.selectedColorC, colorModel.selectedColorD);
            Ohm ohmModel = new Ohm()
            {
                Resistance = result.Item1/1000,
                Tolerance = result.Item2/1000
            };


            StringBuilder resistorResult = new StringBuilder();
            resistorResult.Append("<b>Resistence :</b> " + Math.Round(ohmModel.Resistance, 6).ToString()+"K" + " ohms" + "<br/>");
            //resistorResult.Append("<b>Resistence :</b> " + Math.Round(ohmModel.Resistance, 6).ToString("#.##") + "K" + " ohms" + "<br/>");
            resistorResult.Append("<b>Tolerance :</b> " + ohmModel.Tolerance.ToString() + "<br/>");
            Color tempResponse = new Color();
            tempResponse.resultString = resistorResult.ToString();

            
            return Content(resistorResult.ToString());
        }
    }
}
