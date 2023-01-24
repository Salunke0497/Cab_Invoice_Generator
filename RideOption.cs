using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenretorApp
{
    public class RideOption
    {
        public enum RideType
        {
            NORMAL,
            PREMILM,
        }
        public double cost_Per_Kilo;
        public double cost_Per_Min;
        public double minimum_Fare;
        public RideOption(double cost_Per_Kilo, double cost_Per_Min, double minimum_Fare)
        {
            this.cost_Per_Kilo=cost_Per_Kilo;
            this.cost_Per_Min=cost_Per_Min;
            this.minimum_Fare=minimum_Fare;
        }
        public RideOption()
        {

        }
        public RideOption SetRideValue(RideType rideType)
        {
            switch (rideType)
            {
                case RideType.NORMAL:
                    return new RideOption(10.0, 1.0, 5.0);
                case RideType.PREMILM:
                    return new RideOption(15.0, 2.0, 20.0);
                default:
                    return null;
            }
        }
    }
}
