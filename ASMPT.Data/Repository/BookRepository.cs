using ASMPT.Data.Contract;
using ASMPT.Domain;
using ASMTP.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private DbModelContext _context;
        public BookRepository(DbModelContext context)
        {
            _context = context;
        }
        public void Add(Book book)
        {
            _context.Books.Add(book);
        }

        public void Delete(int id)
        {
            var entity = _context.Set<Book>().Find(id);
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Edit(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
        }

        public List<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public Book GetById(int id)
        {
            return _context.Books.Include(c=>c.Author).FirstOrDefault(c=>c.Id==id);
        }
    }
}
