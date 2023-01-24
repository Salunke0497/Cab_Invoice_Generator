using static CabInvoiceGenretorApp.RideOption;

namespace CabInvoiceGenretorApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Cab Invoice Genretor Program");
            CabInvoiceGenterorCalculation respository = new CabInvoiceGenterorCalculation();
           
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };

            respository.MapRidesTouse("Amol", ride);
            InvoiceSummary summary = respository.GetInvoiceSummary("Amol",RideType.NORMAL);
            Console.WriteLine(summary.totalFare);
        }
    }
       
}