using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndNavision
{
    using Microsoft.AspNetCore.SignalR;
    using RemaCodeUnit;
    class Program
    {
        

        static void Main(string[] args)
        {
            RemaCustomerCodeUnit RCCU = new RemaCustomerCodeUnit();
            RCCU.Url = "http://Mathias:7047/BC140/WS/CRONUS%20International%20Ltd./Codeunit/RemaCustomerCodeUnit";
            RCCU.UseDefaultCredentials = true;
            Console.WriteLine(RCCU.GetCustomerName("1"));
            Console.WriteLine(RCCU.GetCustomerName("2"));


            Console.ReadLine();
        }
    }

    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }

    public class MyHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.addMessage(message);
        }

        public void Recieve(string param)
        {
            Console.WriteLine("Recieved: {0}", param);
        }
    }

}
