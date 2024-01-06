
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Domain;

namespace ASMPT.ApplicationService.Contract
{
    public interface IAuthorService
    { 
        List<AuthorViewModel> GetAll();
    
        AuthorViewModel GetById(int id);
        void Edit(AuthorDto authorDto);
        void Delete(int id);
        int? Add(AuthorDto authorDto);
    }
}