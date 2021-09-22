using Clean.Arc.Domain.Interfaces;
using Clean.Arc.Domain.Models;
using Clean.Arc.Infra.Data.Context;
using System.Collections.Generic;

namespace Clean.Arc.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private VideoCourseDbContext _videoDBContext;

        public CourseRepository(VideoCourseDbContext videoDBContext) {
            _videoDBContext = videoDBContext;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _videoDBContext.Courses;
        }
    }
}
