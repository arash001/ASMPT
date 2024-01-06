using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.Data.Contract.ViewModel
{
    public class CreateAuthorDto
    {
      
            public string Name { get; set; }
            public string Surename { get; set; }

            public ICollection<CreateBookDto>? Book { get; set; }
        
    }
}
