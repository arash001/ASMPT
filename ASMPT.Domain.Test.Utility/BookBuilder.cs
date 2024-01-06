
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.Domain.Test.Utility
{
    public class BookBuilder
    {
        private int _id;
          private string  _title;
          private string  _isbn;
          private int  _authorId;
        private Author _author;

        public BookBuilder WithId(int id)
        {
            this._id = id;
            return this;
        }

        public BookBuilder WithTitle(string title)
        {
            this._title = title;
            return this;
        }


        public BookBuilder WithAuthorId(int id)
        {
            this._authorId = id;
            return this;
        }

        public BookBuilder WithAuthor(Author author)
        {
            this._author = author;
            return this;
        }


        public Book Build()
        {
            return new Book(this._id,this._title,this._isbn,this._authorId,this._author);
        }
    }
}
