using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelectACourse.Models;

namespace SelectACourse.ThirdParty.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {        
        private readonly ILogger<CourseController> _logger;

        public CourseController(ILogger<CourseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Course> Get()
        {
            var rng = new Random();
            return new List<Course>()
            {
                new Course()
                {
                    Id = "1",
                    Tutor = "David Price",
                    Title = "Geology for Beginers",
                    Date = new DateTime(2021, 04, 01),
                    Cost = 20
                },
                new Course()
                {
                    Id = "2",
                    Tutor = "Dr. Graham Sutherland",
                    Title = "Advanced Mathematics",
                    Date = new DateTime(2021, 08, 21),
                    Cost = 120
                },
                new Course()
                {
                    Id = "3",
                    Tutor = "Ronald Jones",
                    Title = "An Introduction to InfoSec",
                    Date = new DateTime(2020, 12, 01),
                    Cost = 75.20m
                },
                new Course()
                {
                    Id = "4",
                    Tutor = "Dr. Stephanie Browne",
                    Title = "Advanced Material Physics",
                    Date = new DateTime(2021, 02, 7),
                    Cost = 95
                }
            };
        }
        
    }
}
