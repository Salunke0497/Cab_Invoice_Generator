using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenretorApp
{
    public class Ride
    {
        public double rideDistance;
        public double rideTime;
     
        /// Initialization a new instance of the class
        
        public Ride(double rideDistance, double rideTime)
        {
            this.rideDistance=rideDistance;
            this.rideTime=rideTime;
        }
    }
}
