using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using ProductCodeUnitRema;
using projectNavision.Models;
using RemaCodeUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace projectNavision.Controllers
{
    public class ChatHub : Hub
    {
        //ports for code units
        RemaCustomerCodeUnit_Port customerPort = null;
        ProducCodeUnitRema_Port productPort = null;

        //Customer results from code units
        GetCustomerName_Result customerResult = null;
        CustomerLogin_Result loginResult = null;
        CreateCustomer_Result createResult = null;

        //Product results from code units
        Product_Result productResult = null;
        Price_Result priceResult = null;

        

        public async Task ItemName(string barcode)
        {
            try
            {
                productPort = new ProducCodeUnitRema_PortClient();
                productResult = await productPort.ProductAsync(new Product(barcode));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine(Clients.All.SendAsync(productResult.return_value));
            await Clients.All.SendAsync("Message sent: " + productResult.return_value);
        }

        public async Task ItemPrice(string barcode)
        {
            try
            {
                productPort = new ProducCodeUnitRema_PortClient();
                priceResult = await productPort.PriceAsync(new Price(barcode));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine(Clients.All.SendAsync(priceResult.return_value));
            await Clients.All.SendAsync("Message sent: " + priceResult.return_value);
        }


        public async Task CodeUnit(string customerID)

        {
            try
            {
                customerPort = new RemaCustomerCodeUnit_PortClient();
                customerResult = await customerPort.GetCustomerNameAsync(new GetCustomerName(customerID));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine(Clients.All.SendAsync(customerResult.return_value));
            await Clients.All.SendAsync("Message sent: " + customerResult.return_value);

            //return result.return_value;
        }

        public async Task LoginCU(string email, string password)
        {
            try
            {
                customerPort = new RemaCustomerCodeUnit_PortClient();
                loginResult = await customerPort.CustomerLoginAsync(new CustomerLogin(email, password));
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine(Clients.All.SendAsync(loginResult.return_value));
            await Clients.All.SendAsync("Message sent: " + loginResult.return_value);

        }

        public async Task CreateCustomerCU(string firstName, string lastName, string email, string password)
        {
            try
            {
                customerPort = new RemaCustomerCodeUnit_PortClient();
                createResult = await customerPort.CreateCustomerAsync(new CreateCustomer(firstName, lastName, email, password));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine(Clients.All.SendAsync(createResult.return_value));
            await Clients.All.SendAsync("Message sent: " + createResult.return_value);

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

        

        public async Task SendMessage(string user, string message)
        {
            
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task JoinChat(string ID)
        {
            await Clients.All.SendAsync("JoinChat" + " Server...", ID);
            Console.WriteLine(Clients.All.SendAsync("JoinChat", ID));

        }

    }
}
