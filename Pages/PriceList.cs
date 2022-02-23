using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MobileDiag.Pages;

public partial class IndexModel : PageModel
{
    public static List<price> Prices =  new List<price>{
        // format Name, price as diplayed, optional comment"
       new price("Program GM","$170","Does not include Used Global A GM PCM’s or any other used module that requires EEprom programming."),
       new price("Used Global A GM PCM","$285","See Global A List for a list of which GM vehicles are Global A architecture. Many modules on these vehicles can NOT be programmed if they are used, but we can EEprom program some of these modules."),
       new price("Program Ford","$170","Does not include BCM’s"),
       new price("Program Ford BCM","$195"),
       new price("Program Chrysler","$185"),
       new price("DRBII Program Chrysler","$225"),
       new price("Program European","$260-495","The price for European vehicles greatly depends on exactly what is needed. In some cases, specifically BMW, we cannot give an exact price until we connect to the vehicle to see exactly how many modules need to be programmed."),
       new price("Used Mercedes Trans","$425","We can EEprom program used Mercedes 7.229 transmissions and conductor plates/valve bodies."),
       new price("Standard Diagnostics","$195","Includes up to 1.5 hours of diagnostic time. This covers most domestic and Asian vehicle diagnostics. Additional time is billed at $100/hr."),
       new price("European Diagnostics","$260","Includes up to 1.5 hours of diagnostic time. This covers most diagnostics. Additional time is billed at $130 per hour."),
       new price("Battery Drains","$225 +","Please see this page on how to prepare a vehicle for battery drain testing. This type of diagnosis can be time consuming.  Expect that it is likely this diagnostic will go over the typical 1.5 hour time slot and any additional time will be billed at $100 per hour."),
       new price("Diagnose Hybrid","$225"),
       new price("Flood vehicles","Call","Flood vehicles are the most time consuming type of diagnosis and often require multiple visits. We generally wont take these jobs in without the understanding that we bill by the hour and can never guarantee that any recommended repairs are the only repairs that will be necessary. This is the one type of diag that often requires repairs to be performed in steps before further diagnostics can take place. It is not uncommon for this to be anywhere from $250 to over $1000 to fully diagnose the vehicle."),
       new price("Program Nissan","$180","For Nissan transmissions, we will provide proof of programming and proper calibration using the factory Nissan Consult III scan tool so that you have proper documentation for a warranty if you bought the transmission from a dealership."),
       new price("Program Mazda","$190"),
       new price("Program Honda","$175"),
       new price("Program Toyota","$190"),
       new price("Program Hyundai/Kia","$190"),
       new price("Program Keys Only","$160","This is for keys only. It does NOT include programming a new immobilizer or security module or doing any programming with any other module. Often, we are required to program keys as part of another job such as PCM or BCM replacement. This lower price option is ONLY for people that bought a spare key and need it programmed and not for module replacement."),
       new price("Trip Charge","$90","Our least favorite , but necessary thing to charge for. To avoid this charge, try to make certain the module you are installing is correct for the vehicle. Make certain the module is correct and also make sure it will communicate. Our most common trip charge is for programming a module that has no communication when we arrive. If installing a used module, be sure to ask us if a used module can even be done on that specific application. Many used modules cannot be ")
       //new price()  // no comma on the last one
    };


        public class price{
        public string Name {get;set;}= "&nbsp;";
        public string Price{get;set;} = "&nbsp;";
        public string Description{get;set;}= "&nbsp;";

        public price(){}
        public price(string name,string price, string desc="")
        {
            Name = name;
            Price = price;
            Description = desc;
        }

    }
}
