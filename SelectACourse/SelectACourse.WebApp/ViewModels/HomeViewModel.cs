using SelectACourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectACourse.WebApp.ViewModels
{
    public class HomeViewModel
    {
        public string StudentId { get; set; }
        public IEnumerable<Course> Courses { get; set; }

    }
}
