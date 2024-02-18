using KodlamaioSimulation.DataAccess.Abstract;
using KodlamaioSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.DataAccess.Concrete.EntityFramework
{
    public class EfCourseDal : ICourseDal
    {
        List<Course> courses;

        public EfCourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Price = 0;
            course1.InstructorId = 1;
            course1.Name = "C# 2024";
            course1.Description = "C# 2024 Kampı";

            Course course2 = new Course();
            course2.Id = 2;
            course2.Price = 0;
            course2.InstructorId = 2;
            course2.Name = "Senior Yazılım Geliştirici Yetiştirme Kampı";
            course2.Description = "Ücretsiz ve profesyonel bir programla, ileri seviye yazılım geliştirme öğreniyoruz.";


            courses =new List<Course>() { course1, course2 };   
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Remove(Course course)
        {
            courses.Remove(course);
        }

        public void Update(Course course)
        {
            Course updatedCourse=courses.SingleOrDefault(c=>c.Id == course.Id);
            course.Name= updatedCourse.Name;
            course.Description= updatedCourse.Description;
            course.Price= updatedCourse.Price;
        }
    }
}
