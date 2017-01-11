using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostCodeWebServiceClient
{
    using PostCodeInfoService;

    class Program
    {
        static void Main(string[] args)
        {
            PostCodeInfo postCodeInfo = new PostCodeInfo();
            Console.WriteLine(postCodeInfo.GetCityByPostCode("BR 22291-040"));
            Console.ReadLine();
        }
    }
}
