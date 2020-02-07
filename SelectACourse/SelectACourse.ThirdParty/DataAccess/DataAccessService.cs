using SelectACourse.Models;
using SelectACourse.ThirdParty.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectACourse.ThirdParty.DataAccess
{
    public class DataAccessService
    {
        private readonly CourseSelectDbContext _courseSelectDbContext;

        public DataAccessService(CourseSelectDbContext courseSelectDbContext)
        {
            _courseSelectDbContext = courseSelectDbContext;
        }

        internal IEnumerable<Enrolment> GetEnrolments(string studentId) =>
            _courseSelectDbContext.EnrolmentEntities
                .Where(a => a.StudentId == studentId);

        internal void Enrol(string courseId, string studentId)
        {
            var enrolmentEntity = new EnrolmentEntity()
            {
                CourseId = courseId,
                StudentId = studentId
            };
            _courseSelectDbContext.EnrolmentEntities.Add(enrolmentEntity);
            _courseSelectDbContext.SaveChanges();

        }

        internal IEnumerable<Course> GetCourses() =>
            _courseSelectDbContext.CourseEntities
            .ToList();
    }
}
