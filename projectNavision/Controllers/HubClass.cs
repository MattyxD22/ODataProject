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
    public class HubClass : Hub
    {
        CustomerPageRema customer;
        CustomerPageRema_Filter nameFilter = new CustomerPageRema_Filter();
        List<CustomerPageRema_Filter> filterArray = new List<CustomerPageRema_Filter>();
        public async Task CodeUnit()
        {

            CustomerPageRema client = new CustomerPageRema();
            GetCustomerName test = new GetCustomerName();
            Console.WriteLine(test);
            await Clients.All.SendAsync("Message sent: " + test.ToString());
            


        }

        public async Task JoinChat(string user)
        {
            user = "Mathias";
            await CodeUnit();
            await Clients.All.SendAsync("JoinChat", user);
            GetCustomerName_Result result = new GetCustomerName_Result();
            Console.WriteLine(result.return_value);


            nameFilter.Field = CustomerPageRema_Fields.FirstName;
            Console.WriteLine(nameFilter.Criteria ="M*");
            filterArray.Add(nameFilter);
            foreach (var item in filterArray)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(Clients.All.SendAsync("JoinChat", user));
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
