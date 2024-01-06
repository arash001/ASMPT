using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.Data.Contract.ViewModel
{
    public class BorrowViewModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StudentId { get; set; }
        public int BookId { get; set; }

        public StudentViewModel Student { get; set; }
        public BookViewModel Book { get; set; }
    }
}
