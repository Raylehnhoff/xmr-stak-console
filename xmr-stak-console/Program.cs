using RestSharp;
using System;
using xmr_stak_sharp;

namespace xmr_stak_console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new RestClient("http://192.168.86.72:10080");
            var request = new RestRequest("api.json", Method.GET);
            var response = client.Execute<XmrStakRoot>(request);
            //Just an example
            Console.WriteLine(response.Data.hashrate.total[0] * response.Data.hashrate.highest);
            Console.WriteLine(client.BuildUri(request));
        }
    }
}