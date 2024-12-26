using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ
{
    public class Courses
    {
      public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Level { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public ICollection<Students> Students { get; set; }
    public ICollection<Exam> Exams { get; set; }

    public Courses()
    {
        Students = new List<Students>();
        Exams = new List<Exam>();
    }
    }
}
