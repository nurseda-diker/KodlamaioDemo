using KodlamaioSimulation.Business.Concrete;
using KodlamaioSimulation.DataAccess.Concrete.EntityFramework;
using KodlamaioSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CourseTest();

            InstructorTest();
            CategoryTest();

            Console.ReadLine();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            var result = categoryManager.GetAll();
            if (result != null)
            {
                foreach (var category in result)
                {
                    Console.WriteLine(category.Name);
                }
            }
        }

        private static void InstructorTest()
        {
            InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());
            var result = instructorManager.GetAll();
            if (result != null)
            {
                foreach (var instructor in result)
                {
                    Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
                }
            }
        }

        private static void CourseTest()
        {
            CourseManager courseManager = new CourseManager(new EfCourseDal());

            var result = courseManager.GetAll();
            if (result != null)
            {

                foreach (var course in result)
                {
                    Console.WriteLine(course.Name);
                }
            }
        }
    }
}
