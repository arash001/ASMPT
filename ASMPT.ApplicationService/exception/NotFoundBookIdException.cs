using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.ApplicationService.exception
{
    public class NotFoundBookIdException:Exception
    {
        public string BookId { get; set; }
        public NotFoundBookIdException(string bookid)
        {
            this.BookId = bookid;
        }
    }
}
