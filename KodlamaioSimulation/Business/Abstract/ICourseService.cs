using KodlamaioSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.Business.Abstract
{
    public interface ICourseService
    {
        void Add(Course course);
        void Remove(Course course);
        void Update(Course course);
        List<Course> GetAll();
    }
}
