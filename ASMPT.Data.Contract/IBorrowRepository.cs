using ASMPT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.Data.Contract
{
    public interface IBorrowRepository
    {
        public int Create(Borrow borrow);
        public List<Borrow> GetBorrowByBook( int bookId);
       public List<Borrow> GetBorrowByStudent( int studentId);

    }
}
