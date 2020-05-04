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
        CustomerPageRema customer;
        CustomerPageRema_Filter nameFilter = new CustomerPageRema_Filter();
        List<CustomerPageRema_Filter> filterArray = new List<CustomerPageRema_Filter>();
        public async Task<string> CodeUnit(string customerID)
        {
            RemaCustomerCodeUnit_Port test = null;
            GetCustomerName_Result result = null;
            //try
            //{
                
            //    test = new RemaCustomerCodeUnit_PortClient();
            //    result = await test.GetCustomerNameAsync(new GetCustomerName(customerID));
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Error: " + ex.Message);
            //}

            test = new RemaCustomerCodeUnit_PortClient();
            result = await test.GetCustomerNameAsync(new GetCustomerName(customerID));

            Console.WriteLine(result.return_value);
            await Clients.All.SendAsync(result.return_value);
            return result.return_value;
            
            
            //await Clients.All.SendAsync("Message sent: " + test.ToString());
            


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

        public async Task JoinChat(int ID)
        {
            await Clients.All.SendAsync("JoinChat", ID);
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



        //[Route("[controller]")]

        //[HttpGet("{id}")]
        //public async Task<string> GetStudent(int id)
        //{
        //    StudentSOAP.Student_PortClient test = new StudentSOAP.Student_PortClient();
        //    var result = await test.GetStudentAsync();
        //    Student studentBuilder = new Student();




        //    return result.ToString();
        //}

        //private readonly ILogger<HubClass> _logger;

        //public HubClass(ILogger<HubClass> logger)
        //{
        //    _logger = logger;
        //}

        //static void PrintCustomerList(CustomerPageRema_Service service, List<CustomerPageRema_Filter> filter)
        //{
        //    Msg("Printing Customer List");

        //    // Runs the actual search.
        //    CustomerPageRema[] list = service.ReadMultiple(filter.ToArray(), null, 100);
        //    foreach (CustomerPageRema c in list)
        //    {
        //        PrintCustomer(c);
        //    }
        //    Msg("End of List");
        //}

        static void PrintCustomer(CustomerPageRema c)
        {
            Console.WriteLine("No: {0} Name: {1}", c.ID, c.FirstName);
        }

        static void Msg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
