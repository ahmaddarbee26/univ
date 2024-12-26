using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ
{
    public class Students
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string Email {  get; set; }
        public string Password { get; set; }    
        public string U_Major {  get; set; }

        public ICollection<Courses> Courses { get; set; }
        public int ExamResultId { get; set; }
        public ExamResult ExamResult { get; set; }


    }
}
