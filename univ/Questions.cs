using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ
{
    public class Questions
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> Choices { get; set; }
        public string Answer { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }

    }
}
