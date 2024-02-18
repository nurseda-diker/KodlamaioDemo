using KodlamaioSimulation.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.Entities.Concrete
{
    public class Instructor:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
    }
}
