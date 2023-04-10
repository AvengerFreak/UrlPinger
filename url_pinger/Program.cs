using System;

namespace url_pinger{

    class Program{

        static void Main(string[] args){
            
            var ping = new System.Net.NetworkInformation.Ping();
            var result = ping.Send("www.google.com");

            if (result.Status != System.Net.NetworkInformation.IPStatus.Success){
                Console.WriteLine("Service is down");
            }
                
            else
            {
                Console.WriteLine("Service is up");
            }

        }
    }
}
