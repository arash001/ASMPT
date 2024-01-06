using ASMPT.Domain.Test.Utility;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ASMPT.Domain
{
    public class BookTests
    {
        private readonly BookBuilder _bookBuilder;

        public BookTests(BookBuilder bookBuilder)
        {
            _bookBuilder = bookBuilder;
        }

        public static IEnumerable<object[]> InvalidStringName()
        {
            yield return new object[] { "" };
            yield return new object[] { string.Empty };
        }

        public static IEnumerable<object[]> InvalidISBNCodes()
        {
            yield return new object[] { "jhasdjasd" };
            yield return new object[] { "1231545" };
            yield return new object[] { "" };
            yield return new object[] { null };
        }


        [Theory]
        [MemberData(nameof(InvalidStringName))]
        public void When_Book_Titel_Is_NullorEmpty_Throw_Exception(string name)
        {
            //var id = 1;
            //var authorId = 1;
            //var titel = "titel";
            //int authorid = 0;
            //string authorname = "author name";
            //var author = new Author(authorid, authorname);
            //string isbn = "0-306-40615-2";
            //var book = new Book(id,isbn,authorId,author);
            //_bookBuilder.WithId(id).WithTitle(titel).WithId(authorId);

            Assert.Throws<InvalidBookTitelException>(() =>
            {
                var student = _bookBuilder.Build();

            });
        }



        //[Theory]
        //[MemberData(nameof(InvalidStringName))]
        //public void When_Book_ISBN_Is_Not_Valid_Throw_Exception(string isbncode)
        //{
        //    var id = 1;
        //    //var authorId = 1;
        //    var titel = "titel";
        //    int authorid = 0;
        //    string authorname = "author name";
        //    var author = new Author(authorid, authorname,new Author("authorname","authorsurename",new Book(id, "titel","ias");
        //    //string isbn = "0-306-40615-2";
        //    var book = new Book(id,isbn,authorId,author);
        //    //_bookBuilder.WithId(id).WithTitle(titel).WithId(authorId);

        //    var isbn = isbncode;
        //    _bookBuilder.WithId(id).WithTitle(titel).WithAuthorId(authorid).WithAuthor(author);
        //    var  exception =Assert.Throws<InvalidBokkISBNException>(() =>
        //    {
        //        var student = _bookBuilder.Build();

        //    });
        //    exception.ISBN.Should().Be(isbn);

        //}
    }
}
