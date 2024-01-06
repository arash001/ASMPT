using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPTUIWinForm.Model
{
    public class Author
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surename { get; set; }
        public List<Book> book { get; set; }
    }
}
