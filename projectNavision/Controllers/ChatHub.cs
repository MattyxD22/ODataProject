using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using projectNavision.Models;
using RemaCodeUnit;
using RemaCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace projectNavision.Controllers
{
    public class ChatHub : Hub
    {
        RemaCustomerCodeUnit_Port test = null;
        GetCustomerName_Result result = null;
        


        public async Task CodeUnit(string customerID)
        {
           
            test = new RemaCustomerCodeUnit_PortClient();
            result = await test.GetCustomerNameAsync(new GetCustomerName(customerID));

            //try
            //{

                
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Error: " + ex.Message);
            //}



            Console.WriteLine(Clients.All.SendAsync(result.return_value));
            await Clients.All.SendAsync("Message sent: " + result.return_value);
            

            //return result.return_value;
          

        }

        public void BroadcastMessage(string name, string message)
        {
            Clients.All.SendAsync("broadcastMessage", name, message);
            Console.WriteLine(Clients.All.SendAsync("broadcastMessage", name, message));
        }

        public void Echo(string name, string message)
        {
            Clients.Client(Context.ConnectionId).SendAsync("echo", name, message + " (echo from server)");
            Console.WriteLine(Clients.Client(Context.ConnectionId).SendAsync("echo", name, message + " (echo from server)"));
        }

        public async void TestIvoke()
        {
            Clients.All.SendAsync("Test Invoke virker??");
            Console.WriteLine(Clients.All.SendAsync("Test Invoke virker??"));
            test = new RemaCustomerCodeUnit_PortClient();
            result = await test.GetCustomerNameAsync(new GetCustomerName("1"));
            Console.WriteLine(result);
        }

        public async Task SendMessage(string user, string message)
        {
            //test = new RemaCustomerCodeUnit_PortClient();
            //result = await test.GetCustomerNameAsync(new GetCustomerName(user));
            //Console.WriteLine(test.GetCustomerNameAsync(new GetCustomerName(user)));
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task JoinChat(string ID)
        {
            await Clients.All.SendAsync("JoinChat" + " Server...", ID);
            Console.WriteLine(Clients.All.SendAsync("JoinChat", ID));
            
            
            //RemaCustomerCodeUnit_Port test = null;
            //GetCustomerName_Result result = null;
            //try
            //{
            //    test = new RemaCustomerCodeUnit_PortClient();
            //    result = await test.GetCustomerNameAsync(new GetCustomerName(ID));
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Error: " + ex.Message);
            //}
            //Console.WriteLine(result.return_value);
            ////return result.return_value;


        }



    }
}
