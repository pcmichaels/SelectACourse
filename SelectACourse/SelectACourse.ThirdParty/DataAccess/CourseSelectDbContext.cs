using Microsoft.EntityFrameworkCore;
using SelectACourse.ThirdParty.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectACourse.ThirdParty.DataAccess
{
    public class CourseSelectDbContext : DbContext
    {
        public CourseSelectDbContext(DbContextOptions<CourseSelectDbContext> options)
            : base(options)
        {

        }

        public DbSet<CourseEntity> CourseEntities { get; set; }
        public DbSet<EnrolmentEntity> EnrolmentEntities { get; set; }
    }
}
