using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projectNavision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectNavision.Controllers
{
    public class HubClass
    {
        [Route("[controller]")]

        [HttpGet("{id}")]
        public async Task<string> GetStudent(int id)
        {
            StudentSOAP.Student_PortClient test = new StudentSOAP.Student_PortClient();
            var result = await test.GetStudentAsync();
            Student studentBuilder = new Student();

            
           

            return result.ToString();
        }

        private readonly ILogger<HubClass> _logger;

        public HubClass(ILogger<HubClass> logger)
        {
            _logger = logger;
        }

      


    }
}
