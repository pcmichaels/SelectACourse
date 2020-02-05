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
            : base(options) { }

        public DbSet<CourseEntity> CourseEntities { get; set; }
        public DbSet<EnrolmentEntity> EnrolmentEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEntity>().HasData(
                new CourseEntity()
                {
                    Id = "1",
                    Tutor = "David Price",
                    Title = "Geology for Beginers",
                    Date = new DateTime(2021, 04, 01),
                    Cost = 20
                },
                new CourseEntity()
                {
                    Id = "2",
                    Tutor = "Dr. Graham Sutherland",
                    Title = "Advanced Mathematics",
                    Date = new DateTime(2021, 08, 21),
                    Cost = 120
                },
                new CourseEntity()
                {
                    Id = "3",
                    Tutor = "Ronald Jones",
                    Title = "An Introduction to InfoSec",
                    Date = new DateTime(2020, 12, 01),
                    Cost = 75.20m
                },
                new CourseEntity()
                {
                    Id = "4",
                    Tutor = "Dr. Stephanie Browne",
                    Title = "Advanced Material Physics",
                    Date = new DateTime(2021, 02, 7),
                    Cost = 95
                });            
        }
    }
}
