using TheMatch.Domain;

namespace TheMatch.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var courserepo = new Infrastructure.SampleData.CourseRepository();

            foreach (Course course in courserepo.GetCourses())
            {
                System.Console.WriteLine(course.Name);
            }
            
        }
    }
}
