using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ElectronicRatingCalculatorComponent
{
    /// <summary>
    /// Class for band color
    /// </summary>
    public class ResistorBand 
    {
        /// <summary>
        /// Flag for indication uneused color
        /// </summary>
        public const int EMPTY_COLOR = -3;

        /// <summary>
        /// Band color
        /// </summary>
        public string Color { set; get; }

        /// <summary>
        /// Band color name
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// Band digit (used for counting resistance base)
        /// </summary>
        public int Digit { set; get; }

        /// <summary>
        /// Band resistance multiplier
        /// </summary>
        public int Multiplier { set; get; }

        /// <summary>
        /// Band color Tolerance value
        /// </summary>
        public double Tolerance { set; get; }

        /// <summary>
        /// Band temperature cofficency
        /// </summary>
        public int Tempco { set; get; }

        /// <summary>
        /// public constructor
        /// </summary>
        /// <param name="color"></param>
        /// <param name="name"></param>
        /// <param name="digit"></param>
        /// <param name="multiplier"></param>
        /// <param name="tolerance"></param>
        /// <param name="tempco"></param>
        public ResistorBand(string color, int digit, int multiplier,
            double tolerance, int tempco)
        {
            Color = color;
            
            Digit = digit;
            Multiplier = multiplier;
            Tolerance = tolerance;
            Tempco = tempco;
        }

        /// <summary>
        /// Creating Resistor Band collection
        /// </summary>
        /// <returns></returns>
        public static List<ResistorBand> LoadResistorBands()
        {
            List<ResistorBand> tempList = new List<ResistorBand>()
            {
                new ResistorBand("Black",0,0,EMPTY_COLOR,EMPTY_COLOR),
                new ResistorBand("Brown",1,1,1,100),
                new ResistorBand("Red",2,2,2,50),
                new ResistorBand("Orange",3,3,3,15),
                new ResistorBand("Yellow",4,4,4,25),
                new ResistorBand("Green",5,5,0.5,EMPTY_COLOR),
                new ResistorBand("Blue",6,6,0.25,EMPTY_COLOR),
                new ResistorBand("Violet",7,7,0.1,EMPTY_COLOR),
                new ResistorBand("Gray",8,8,0.05,EMPTY_COLOR),
                new ResistorBand("White",9,9,EMPTY_COLOR,EMPTY_COLOR),
                new ResistorBand("Gold",EMPTY_COLOR,-1,5,EMPTY_COLOR),
                new ResistorBand("Silver",EMPTY_COLOR,-2,10,EMPTY_COLOR),
                new ResistorBand("White",EMPTY_COLOR,EMPTY_COLOR,20,EMPTY_COLOR)
            };
            return tempList;
        }
    }
}
