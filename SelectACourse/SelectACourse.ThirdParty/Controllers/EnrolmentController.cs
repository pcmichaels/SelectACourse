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
        public IActionResult Enrol([FromQuery]string courseId, [FromQuery]string studentId)
        {
            if (_dataAccessService.Enrol(courseId, studentId))
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet]
        public IEnumerable<Enrolment> GetEnrolments(string studentId) =>
            _dataAccessService.GetEnrolments(studentId);

        [HttpGet("[action]/{courseId}")] 
        public int GetEnrolmentsForCourse(string courseId) =>        
            _dataAccessService.GetEnrolmentCountForCourse(courseId);        
    }
}