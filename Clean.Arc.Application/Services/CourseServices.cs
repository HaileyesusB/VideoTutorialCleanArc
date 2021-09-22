using Clean.Arc.Application.Interfaces;
using Clean.Arc.Application.ViewModels;
using Clean.Arc.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Clean.Arc.Application.Services
{
    public class CourseServices : ICourseService
    {
        private ICourseRepository _courSeRepository;

        public CourseServices(ICourseRepository courseRepository) {

            _courSeRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Course = _courSeRepository.GetCourses()
            };
        }
    }
}
