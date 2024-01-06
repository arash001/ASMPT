using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ASMPT.Domain
{
    public class Borrow
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StudentId { get; set; }
        public int BookId { get; set; }

        public Student Student { get; set; }
        public Book Book { get; set; }

        public Borrow()
        {
            
        }
    }
}
