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
using System.Data;
namespace ASMPT.Data.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private DbModelContext _context;
  
        private readonly ILogger<AuthorRepository> _logger;
        public AuthorRepository(DbModelContext context, ILogger<AuthorRepository> logger)
        {
            this._context = context;
            _logger = logger;
        }
        public void Add(Author author)
        {

            _context.Authors.Add(author);
        }

        public void Delete(int id)
        {
            var entity = _context.Set<Author>().Find(id);
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Edit(Author author)
        {
            _context.Entry(author).State = EntityState.Modified;
        }

        public Author GetById(int id)
        {
            return _context.Authors.Find(id);
        }

        public Author CreateAuthor(Author author)
        {

            var newAuthor = _context.Authors.Add(author);
            return newAuthor.Entity;

        }

        public List<Author> GetAll()
        {
            return _context.Authors.Include(c=>c.Book).ToList();
        }
    }
}
