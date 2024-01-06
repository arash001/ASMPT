using ASMPT.Data.Contract.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.ApplicationService.Contract
{
    public  interface IBookService
    {
        List<BookViewModel> GetAll();
        List<BookModel> GetModels();
        BookViewModel GetById(int id);
        int Add(BookDto bookDto);
        void Edit(BookDto bookDto);
        void Delete(int id);
    }
}
