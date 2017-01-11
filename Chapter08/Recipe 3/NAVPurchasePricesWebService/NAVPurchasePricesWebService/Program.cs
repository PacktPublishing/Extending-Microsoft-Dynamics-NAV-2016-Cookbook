using System;
using System.Net;
using System.Data.Services.Client;
using System.Collections.Generic;
using System.Linq;

namespace NAVSalesPricesWebService
{
    using PurchasePricesWebService;

    class Program
    {
        static void Main(string[] args)
        {
            NAV nav = new NAV(new Uri("http://localhost:7048/DynamicsNAV90/OData"));
            nav.Credentials = CredentialCache.DefaultCredentials;

            DataServiceQuery<PurchasePrice> query = nav.CreateQuery<PurchasePrice>("PurchasePrice");
            List<PurchasePrice> prices = query.Execute().ToList<PurchasePrice>();

            foreach (PurchasePrice price in prices)
            {
                Console.WriteLine("Item: {0}, Unit cost: {1}", price.Item_No, price.Direct_Unit_Cost);
            }

            Console.ReadLine();
        }
    }
}
