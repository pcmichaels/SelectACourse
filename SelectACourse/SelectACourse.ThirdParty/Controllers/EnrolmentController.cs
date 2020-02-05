using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SelectACourse.Models;

namespace SelectACourse.ThirdParty.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnrolmentController : ControllerBase
    {

        [HttpPost]
        public void Enrol(string id, string studentId)
        {

        }

        [HttpGet]
        public IEnumerable<Enrolment> GetEnrolments()
        {
            throw new NotImplementedException();
        }
    }
}