using System;
using System.Net;
using System.Linq;

namespace WebServiceAccessKeyAuth
{
    using SalesOpportunitiesService;

    class Program
    {
        static void Main(string[] args)
        {
            NAV nav = new NAV(new Uri("https://HP17:7058/NAV2016_WebService/OData"));

            SalesOpportunities opp = new SalesOpportunities();
            CredentialCache cache = new CredentialCache();
            cache.Add(nav.BaseUri, "Basic", new NetworkCredential("NAVUSER", "Oc1CCKHvZabryCcK56y+Il9mE1aKdryn9FB8+q/zEt8="));
            nav.Credentials = cache;

            var salesOpp = from so in nav.SalesOpportunities select so;

            foreach (var o in salesOpp)
                Console.WriteLine("{0}. Estimated value: {1}; Chance of success: {2}\n", o.Description, o.Estimated_Value_LCY, o.Chances_of_Success);

            Console.ReadLine();
        }
    }
}
