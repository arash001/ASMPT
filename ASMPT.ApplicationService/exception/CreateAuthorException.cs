using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.ApplicationService.exception
{
    public class CreateAuthorException : Exception
    {
        public string Message { get; set; }

        public CreateAuthorException(string message)
        {
            this.Message = message;
        }
    }
}
