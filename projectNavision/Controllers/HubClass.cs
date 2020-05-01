using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projectNavision.Models;
using RemaCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectNavision.Controllers
{
    public class HubClass
    {
        public async Task<string> testMethod(string inputstring)
        {
            CustomerPageRema_Port test = null;
            RemaCustomer.

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

      


    }
}
