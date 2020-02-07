using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelectACourse.Models;
using SelectACourse.ThirdParty.DataAccess;

namespace SelectACourse.ThirdParty.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {        
        private readonly ILogger<CourseController> _logger;
        private readonly DataAccessService _dataAccessService;

        public CourseController(ILogger<CourseController> logger,
            DataAccessService dataAccessService)
        {
            _logger = logger;
            _dataAccessService = dataAccessService;
        }

        [HttpGet]
        public IEnumerable<Course> GetCourses() =>
            _dataAccessService.GetCourses();        
        
    }
}
