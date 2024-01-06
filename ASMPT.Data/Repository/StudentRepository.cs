using ASMPT.Data.Contract;
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Domain;
using ASMTP.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.Data.Repository
{
    public class StudentRepository:IStudentRepository
    {
        private DbModelContext _context;
        public StudentRepository(DbModelContext context)
        {
            _context = context;
        }

        public Student GetById(int id)
        {
            return _context.Students.Include(l => l.Address).FirstOrDefault(l => l.Id==id);
        }

        public List<Borrow> GetBorrowedBooks()
        {
                return _context.Borrows.Include(l => l.Book).Include(l => l.Student).ToList();
        }

        public void Add(Student student)
        {
            
                _context.Students.Add(student);
            //_context.SaveChanges();
            
        }

     

        public void Edit(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return _context.Students.Include(c => c.Address).ToList();
        }
    }
}

