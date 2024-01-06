using ASMPT.Domain;

namespace ASMPT.Data.Contract
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        void Add(Book book);
        void Edit(Book book);
        void Delete(int id);
    }
}