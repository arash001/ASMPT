
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Domain;

namespace ASMPT.ApplicationService.Contract
{
    public interface IBorrowService
    {


        public int CreateBorrow(CreateBorrow createBorrow);
        public List<BorrowViewModel> GetBorrowByStudentId(int studentId);
        public List<BorrowViewModel> GetBorrowByBookId(int bookId);
    }
}