using Clean.Arc.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Arc.Application.Interfaces
{
  public interface ICourseService
    {
        CourseViewModel GetCourses();

    }
}
