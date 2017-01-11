using System;
using System.Net;
using System.Linq;

namespace NAVSalesOrdersWebService
{
    using SalesOrdersWebService;

    class Program
    {
        static void Main(string[] args)
        {
            NAV nav = new NAV(new Uri("http://localhost:7048/DynamicsNAV90/OData"));
            nav.Credentials = CredentialCache.DefaultCredentials;

            var orders = from so in nav.SalesOrder
                         where so.Status == "Released" || so.Status == "Pending Approval" || so.Status == "Pending Prepayment"
                         select so;

            foreach (SalesOrder order in orders)
            {
                Console.WriteLine(
                    "Order No.: {0}, Sell-to Customer: {1}, {2:d}",
                    order.No, order.Sell_to_Customer_Name, order.Due_Date);
            }

            Console.ReadLine();
        }
    }
}
