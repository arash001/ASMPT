using ASMPT.Data.Contract;
using ASMPT.Domain;
using ASMTP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.Data.Repository
{
    public class BorrowRepository : IBorrowRepository
    {
        private DbModelContext _context;
        private readonly ILogger<BorrowRepository> _logger;
        public BorrowRepository(DbModelContext context, ILogger<BorrowRepository> logger)
        {
            this._context = context;
            _logger = logger;
        }
        public int Create(Borrow borrow)
        {
            try
            {
                this._context.Borrows.Add(borrow);
                this._context.SaveChanges();

                return borrow.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while creating a borrow.", ex);
                return 0;
            }
        }

        public List<Borrow> GetBorrowByBook(int bookId)
        {
            var student = _context.Students.Find(bookId);
            if (student is null) throw new Exception();
            return _context.Borrows.Include(c=>c.Book).Include(c=>c.Student)
                .Where(c => c.BookId == bookId).ToList();
        }

        public List<Borrow> GetBorrowByStudent(int studentId)
        {
            var student = _context.Students.Find(studentId);
            if (student is null) throw new Exception();
            
                return _context.Borrows.Include(bb => bb.Book).Include(c=>c.Student).Where(t=> t.StudentId == studentId)
                    .ToList();
        }
    }
}
