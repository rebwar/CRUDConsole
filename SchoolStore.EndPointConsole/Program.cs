using SchoolStore.DAL;
using System;
using System.Linq;

namespace SchoolStore.EndPointConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolDb())
            {
                 Add(ctx);
                // Update(ctx);
                //Delete(ctx);
                Select(ctx);
                ctx.SaveChanges();
            }




            Console.ReadLine();
        }

        private static void Select(SchoolDb ctx)
        {
            var courses = ctx.Courses.ToList();
            foreach (var item in courses)
            {
                Console.WriteLine($"Course Id={item.CourseId}  Course Name:{item.Name}");
            }
        }

        private static void Delete(SchoolDb ctx)
        {
            var course = ctx.Courses.Find(1);
            ctx.Courses.Remove(course);
        }

        private static void Update(SchoolDb ctx)
        {
            var course = ctx.Courses.Find(1);
            course.Name = "ASP.NET Core";
        }

        private static void Add(SchoolDb ctx)
        {
            ctx.Courses.Add(new Domain.Course
            {
                Name = "ASP.NET Core 3.0"
            });
        }
    }
}
