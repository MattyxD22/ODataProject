﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using Owin;
using Microsoft.Owin.Cors;

namespace NavisionBackend
{
    using Microsoft.AspNet.SignalR.Client;
    using RemaCodeUnit;

    class Program
    {
        static void Main(string[] args)
        {
            var myHub = new MyHub();
            // This will *ONLY* bind to localhost, if you want to bind to all addresses
            // use http://*:8080 to bind to all addresses. 
            // See http://msdn.microsoft.com/library/system.net.httplistener.aspx 
            // for more information.
            string url = "http://localhost:44379";
            using (WebApp.Start(url))
            {
                
                Console.WriteLine("Server running on {0}", url);
                Console.WriteLine(myHub.CodeUnit("1"));

                
                Console.ReadLine();
            }

        }
    }

    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            app.MapSignalR();
            app.Map("/MyHub", map =>
            {
                app.UseCors(CorsOptions.AllowAll);
                var hubConfiguration = new HubConfiguration
                {

                };

                hubConfiguration.EnableDetailedErrors = true;
                map.RunSignalR(hubConfiguration);
            });
        }
    }
    public class MyHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addMessage(name, message);
        }

        public async Task<string> CodeUnit(string customerID)
        {
            RemaCustomerCodeUnit RCCU = new RemaCustomerCodeUnit();
            RCCU.Url = "http://Mathias:7047/BC140/WS/CRONUS%20International%20Ltd./Codeunit/RemaCustomerCodeUnit";
            RCCU.UseDefaultCredentials = true;
            Console.WriteLine(RCCU.GetCustomerName("1"));
            Console.WriteLine(RCCU.GetCustomerName("2"));
            Clients.All.addMessage(RCCU.GetCustomerName(customerID));

            return RCCU.GetCustomerName(customerID);

        }

    }

}
