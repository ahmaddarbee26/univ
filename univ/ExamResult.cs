using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ
{
    public class ExamResult
    {
        public int Id { get; set; }
        public int result { get; set; }
        public int StudentId { get; set; }
        public Students Student { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
