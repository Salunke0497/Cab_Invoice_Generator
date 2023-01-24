using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenretorApp
{
    public class InvoiceSummary
    {
        public double totalFare;
        public double averageFare;
        public int noOfRide;
        public InvoiceSummary(double totalFare, int noOfRide)
        {
            this.totalFare=totalFare;

            this.noOfRide=noOfRide;
           
            this.averageFare=this.totalFare/this.noOfRide;
        }
    }
}
