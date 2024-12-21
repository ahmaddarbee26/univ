using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
  public class Teacher
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Collage { get; set; }

        public ICollection<Courses> Courses { get; set; }

        public Teacher()
        {
            Courses = new List<Courses>();
        }
    }
}
