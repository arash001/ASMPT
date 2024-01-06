using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.ApplicationService.exception
{
    public class NotFoundStudentIdException:Exception
    {
        public string StudentId { get; set; }
        public NotFoundStudentIdException(string stuid)
        {
            this.StudentId = stuid;
        }
    }
}
