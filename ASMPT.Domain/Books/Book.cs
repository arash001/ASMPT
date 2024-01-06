
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using ASMPT.Domain.Utility;

namespace ASMPT.Domain
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; } 
        public virtual Author? Author { get; set; }

        public Book()
        {
            
        }
        public Book(int id, string title, string isbn, int authorId, Author? author)
        {
          
            SetProperties(id, title, isbn, authorId, author);
        }

        private void SetProperties(int id, string title, string isbn, int authorId, Author? author)
        {
            
            Id = id;
            Title = title;
            ISBN = isbn;
            AuthorId = authorId;
            Author = author;
            if (string.IsNullOrEmpty(title)) throw new InvalidBookTitelException();
            if (string.IsNullOrEmpty(isbn)) throw new InvalidBookIsbnException();
            if (!ISBNValidator.IsValidISBN(isbn)) throw new InvalidBokkISBNException(isbn);
        }


    }

}