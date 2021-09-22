using Clean.Arc.Domain.Models;
using System.Collections.Generic;

namespace Clean.Arc.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
