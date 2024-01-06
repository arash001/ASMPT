using ASMPT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.Data.Contract.ViewModel
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }

        public  ICollection<BookDto>? Book { get; set; }
      
    }
}
