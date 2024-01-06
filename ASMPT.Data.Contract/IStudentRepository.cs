using ASMPT.Data.Contract.ViewModel;
using ASMPT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ASMPT.Data.Contract
{
    public interface IStudentRepository
    {
        public void Add(Student student);
        public void Edit(Student student);
        public void Delete(int id);
        public Student GetById(int id);
        public List<Student> GetAll();
          
     

    }
}
