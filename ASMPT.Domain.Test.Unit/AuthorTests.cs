
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
    public class AuthorTests
    {
        public static IEnumerable<object[]> InvalidStringName()
        {
            yield return new object[] { "" };
            yield return new object[] { string.Empty };
        }

        public static IEnumerable<object[]> InvalidStringISBN()
        {
            yield return new object[] { "4465464654564656546" };
            yield return new object[] { "345" };
            yield return new object[] { "" };
        }


        private readonly AuthorBuilder _authorBuilder;
        private readonly BookBuilder _bookBuilder;

        public AuthorTests()
        {
            _authorBuilder = new AuthorBuilder();
        }

        [Theory]
        [MemberData(nameof(InvalidStringName))]
        public void When_AuthorName_Is_NullorEmpty_Throw_Exception(string name)
        {
            // Arrange
            var id = 1;
            var authorname = name;
            var address = new Address(1, "Munich", "23", "streetname", "81737");
            var addressId = 1;
            var surename = "surename";

            var builder = new AuthorBuilder()
                .WithName(authorname)
                .WithSurename(surename)
                .WithId(id)
                .WithBook(bookBuilder => bookBuilder.WithTitle("BookTitle").WithISBN("9780471958697").WithId(id).WithAuthorId(id));

            // Act & Assert
            Assert.Throws<InvalidAuthorNameException>(() =>
            {

                var sut = builder.Build();
            });
        }


        [Theory]
        [MemberData(nameof(InvalidStringISBN))]
        public void When_ISBN_Is_Not_Valid_Throw_Exception(string isbn)
        {
            // Arrange
            var id = 1;
            var authorName = "authorname";
            var surename = "surename";

            // Act & Assert
            Action act = () =>
            {
                var author = new AuthorBuilder()
                    .WithId(id)
                    .WithName(authorName)
                    .WithSurename(surename)
                    .WithBook(bookBuilder => bookBuilder.WithTitle("InvalidBookTitle").WithISBN(isbn)).Build();
            };

            act.Should().Throw<InvalidBokkISBNException>()
                .WithMessage($"Invalid ISBN: {isbn}");
              
        }
    }

}
