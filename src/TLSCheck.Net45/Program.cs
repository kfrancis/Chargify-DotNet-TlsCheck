using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TLSCheck.Net45
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Checking .NET 4.5 ..");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                using (WebClient client = new WebClient())
                {
                    string output = client.DownloadString("https://tlscheck.chargify.com/");
                    Console.WriteLine(output);
                }

                Console.WriteLine("Press any key to stop...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
