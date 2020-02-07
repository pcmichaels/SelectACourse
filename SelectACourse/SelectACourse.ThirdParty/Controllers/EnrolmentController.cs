using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SelectACourse.Models;
using SelectACourse.ThirdParty.DataAccess;

namespace SelectACourse.ThirdParty.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnrolmentController : ControllerBase
    {
        private readonly DataAccessService _dataAccessService;

        public EnrolmentController(DataAccessService dataAccessService)
        {
            _dataAccessService = dataAccessService;
        }

        [HttpPost]
        public void Enrol(string courseId, string studentId)
        {
            _dataAccessService.Enrol(courseId, studentId);
        }

        [HttpGet]
        public IEnumerable<Enrolment> GetEnrolments(string studentId) =>
            _dataAccessService.GetEnrolments(studentId);
        
    }
}