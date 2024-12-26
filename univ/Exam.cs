using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ
{
   public class Exam
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int CourseId { get; set; }
        public Courses Course { get; set; }
        public ICollection<Questions> Questions { get; set; }

        public Exam()
        {
            Questions = new List<Questions>();
        }
    }
}
