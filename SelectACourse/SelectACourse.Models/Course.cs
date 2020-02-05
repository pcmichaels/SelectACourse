using System;

namespace SelectACourse.Models
{
    public class Course
    {
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public string Tutor { get; set; }

        public string Title { get; set; }

        public decimal Cost { get; set; }
    }
}
