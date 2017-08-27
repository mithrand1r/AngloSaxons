using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public delegate double HeightCalculationHandler(int age);

    public class Race
    {
        private HeightCalculationHandler _calculationHandler;
        private string _name;

        public string Name { get { return _name; }}

        public Race(string race)
        {
            _name = race;
            _calculationHandler = getHeightCalculationHandler(race);
        }

        public double Height(int age)
        {
             return _calculationHandler(age);
        } 

        private HeightCalculationHandler getHeightCalculationHandler(string race)
        {
            switch (race)
            {
                case "Saxon":
                    return new HeightCalculationHandler(HeightCalculation.AngloSaxon);
                case "Angle":
                    return new HeightCalculationHandler(HeightCalculation.AngloSaxon);
                case "Jute":
                    return new HeightCalculationHandler(HeightCalculation.Jute);
                case "Asian":
                    return new HeightCalculationHandler(HeightCalculation.Asian);
                case "Caucasian":
                    return new HeightCalculationHandler(HeightCalculation.Caucasian);
            }
            return null;
        }
    }
}