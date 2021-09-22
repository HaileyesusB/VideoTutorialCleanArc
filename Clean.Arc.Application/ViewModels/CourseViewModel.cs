using Clean.Arc.Domain.Models;
using System.Collections.Generic;

namespace Clean.Arc.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Course { set; get; }
    }
}
