using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMatch.Domain
{
    public interface ICourseRepository
    {
        List<Course> GetCourses();
        Course GetCourse();

        Course GetCourse(int CourseId);
        
        void AddCourse(Course course);
        void DeleteCourse(Course course);
    }
}
