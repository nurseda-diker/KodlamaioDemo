using KodlamaioSimulation.Business.Abstract;
using KodlamaioSimulation.DataAccess.Abstract;
using KodlamaioSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal) 
        { 
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Remove(Course course)
        {
           _courseDal.Remove(course);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
