using ASMPT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.Data.Contract.ViewModel
{
    public class AuthorViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }

        public ICollection<BookViewModel>? Book { get; set; }
    }
}
