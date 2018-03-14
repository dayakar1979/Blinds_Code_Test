using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicRatingCalculatorComponent
{
    public class OhmValueCalculator : IOhmValueCalculator
    {
        List<ResistorBand> resistorBands = null;


        public OhmValueCalculator()
        {
            resistorBands = ResistorBand.LoadResistorBands();
        }

        public Tuple<double, double> CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            if(bandAColor == null || bandBColor == null ||
                bandCColor == null || bandDColor == null)
            {
                if(bandAColor == null)
                    throw new ArgumentNullException("bandAColor");
                if (bandBColor == null)
                    throw new ArgumentNullException("bandBColor");
                if (bandCColor == null)
                    throw new ArgumentNullException("bandCColor");
                if (bandDColor == null)
                    throw new ArgumentNullException("bandDColor");
            }

            var bandA = resistorBands.Find(x => x.Color == bandAColor);
            var bandB = resistorBands.Find(x => x.Color == bandBColor);
            var bandC = resistorBands.Find(x => x.Color == bandCColor);
            var bandD = resistorBands.Find(x => x.Color == bandDColor);
            var resistence = (bandA.Digit * 10 + bandB.Digit) * Math.Pow(10, bandC.Multiplier);

            return new Tuple<double, double>(resistence, bandD.Tolerance);

        }
    }
}
