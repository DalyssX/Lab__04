using System;
using System.Collections.Generic;
using System.Text;

namespace Lab__04
{
    public class Bike
    {
        public string Brand;
        public string Country;
        public string Region;
        public int Price;
        public double Weight;
        public double Lenghth;
        public bool HasHydraulicBrake;
        public bool HasHydraulicSeatPost;
        public double GetYearIncomePerInhabitant()
        {
            return Price / Weight;
        }
    }
}
