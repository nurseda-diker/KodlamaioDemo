using KodlamaioSimulation.DataAccess.Abstract;
using KodlamaioSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.DataAccess.Concrete.EntityFramework
{
    public class EfInstructorDal : IInstructorDal
    {
        List<Instructor> instructors;

        public EfInstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.FirstName = "Engin";
            instructor1.LastName = "Demiroğ";

            Instructor instructor2 = new Instructor();
            instructor2.Id = 2;
            instructor2.FirstName = "Halit Enes";
            instructor2.LastName = "Kalaycı";

            instructors = new List<Instructor>() { instructor1 ,instructor2};


        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Remove(Instructor instructor)
        {
            instructors.Remove(instructor);
        }

        public void Update(Instructor instructor)
        {
            Instructor updatedInstructor=instructors.SingleOrDefault(i=>i.Id== instructor.Id);
            instructor.FirstName = updatedInstructor.FirstName;
            instructor.LastName = updatedInstructor.LastName;
        }
    }
}
