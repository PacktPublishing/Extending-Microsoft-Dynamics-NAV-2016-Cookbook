using System;
using System.Net;
using System.Linq;
using System.Data.Services.Client;

namespace NAVWebServiceInsertData
{
    using SalesOrdersWebService;

    class Program
    {
        static void Main(string[] args)
        {
            NAV nav = new NAV(new Uri("http://localhost:7048/DynamicsNAV91/OData"));
            nav.Credentials = CredentialCache.DefaultCredentials;

            SalesOrder order = new SalesOrder();
            order.Document_Type = "Order";
            order.No = "00001";
            order.Sell_to_Customer_No = "10000";
            nav.AddToSalesOrder(order);

            SalesOrderLine orderLine = new SalesOrderLine();
            orderLine.Document_Type = "Order";
            orderLine.Document_No = "00001";
            orderLine.Type = "Item";
            orderLine.No = "1001";
            orderLine.Quantity = 2;
            nav.AddToSalesOrderLine(orderLine);

            try
            {
                nav.SaveChanges();
                Console.WriteLine("Sales order was successfully created");
            }
            catch (DataServiceRequestException ex)
            {
                Exception innerEx = ex.InnerException;
                System.Diagnostics.Trace.WriteLine(ex.Message + "\n" + innerEx.Message);
                Console.WriteLine("Could not create the sales order.");
            }

            Console.ReadLine();
        }
    }
}
