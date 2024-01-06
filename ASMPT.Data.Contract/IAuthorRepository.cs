using ASMPT.Domain;

namespace ASMPT.Data.Contract
{
    public interface IAuthorRepository
    {
        public List<Author> GetAll();
        public Author GetById(int id);
        public void Add(Author author);
        public void Edit(Author author);
        public void Delete(int id);
    }
}