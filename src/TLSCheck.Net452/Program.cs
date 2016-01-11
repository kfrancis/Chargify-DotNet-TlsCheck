using System;
using System.IO;
using System.Net;

namespace TLSCheck.Net452
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Checking .NET 4.5.2 ..");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

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
