using SelectACourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectACourse.WebApp.ViewModels
{
    public class CourseViewModel
    {
        public Course Course { get; set; }
        public int Enrolled { get; set; }
    }
}
