
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Domain;

namespace ASMPT.ApplicationService.Contract
{
    public interface IStudentService
    {
        StudentViewModel GetById(int id);
        List<StudentViewModel> GetAll();
        List<StudentModel> GetStudentyModel();
        public int? Add(StudentDto studentDto);

        void Edit(StudentDto studentDto);
        void Delete(int id);
    }
}