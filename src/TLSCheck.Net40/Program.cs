using System;
using System.Linq;
using System.Net;

namespace TLSCheck.Net40
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Checking .NET 4.0 ..");
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

                using (WebClient client = new WebClient())
                {
                    string output = client.DownloadString("https://tlscheck.chargify.com/");
                    Console.WriteLine(output);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
