using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CabInvoiceGenretorApp.RideOption;

namespace CabInvoiceGenretorApp
{
    public class CabInvoiceGenterorCalculation : RideOption
    {
        RideRespository rideRespository = new RideRespository();
     
        RideOption rideoption = new RideOption();
        
        double cabFare = 0.0;

        // Function to calculate total fare (step 1)
        public double CalucalateFare(double distance, double time,RideType rideType)
        {
            RideOption rideop = rideoption.SetRideValue(rideType);
            this.cabFare = (distance*rideop.cost_Per_Kilo)+(time*rideop.cost_Per_Min);

            return Math.Max(this.cabFare, rideop.minimum_Fare);
            // becuase the min fare is 5 means we get cabfare is 4 then it will be minimum fare is constant(5)
        }
       
        // Ride (step 2)
        
        public double GetMultipleRideFare(Ride[] rides,RideType rideType)
        {
            double totalRideFare = 0.0;
            foreach (Ride ride in rides)
            {
                totalRideFare +=this.CalucalateFare(ride.rideDistance, ride.rideTime,rideType);
            }
            return totalRideFare;
        }
        
        // SummaryInvocie Avergae fare (step 3)
       
        public InvoiceSummary GetMultipleAverageFare(Ride[] rides,RideType rideType)
        {
            double totalRideFare = 0.0;
            foreach (Ride ride in rides)
            {
                totalRideFare +=this.CalucalateFare(ride.rideDistance, ride.rideTime,rideType); 
            }
            return new InvoiceSummary(totalRideFare, rides.Length);
        }
       
        // Step 4 Given userId And RideRespositories Return Invoice 
        
        public void MapRidesTouse(string userId, Ride[] rides)
        {
            this.rideRespository.AddCabRides(userId, rides);
        }
        public InvoiceSummary GetInvoiceSummary(string userId,RideType rideType)
        {
            return this.GetMultipleAverageFare(this.rideRespository.GetCabRides(userId),rideType);
        }
    }
}
