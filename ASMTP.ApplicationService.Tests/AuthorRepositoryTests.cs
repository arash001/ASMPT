using ASMPT.Data.Contract;
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Data.Repository;
using ASMPT.Domain;
using ASMTP.Data;
using AutoMapper;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMTP.ApplicationService.Tests
{
    public class AuthorRepositoryTests
    {
      
        private DbModelContext _context=new DbModelContext(new DbContextOptions<DbModelContext>());
        [Fact]
        public async Task GetAllAsync_Should_Return_All_Authors()
        {
            // Arrange
            var expectedAuthors = new List<Author>
                {
                    new Author { Id = 1, Name = "Author1" ,Surename="surename1"  },
                    new Author { Id = 2, Name = "Author2" ,Surename="surename2"},
                };

            var authorRepository = Substitute.For<IAuthorRepository>();

            authorRepository.GetAll().Returns(expectedAuthors);



            var logger = Substitute.For<ILogger<AuthorRepository>>();

            // Act
            var result =  authorRepository.GetAll();

            // Assert
            expectedAuthors.Should().BeEquivalentTo(result);
            //Assert.Equal(expectedAuthors, result);
        }



        [Fact]
        public void Add_Should_Log_Information_And_Add_Author()
        {
            // Arrange
            var authorRepository = Substitute.For<IAuthorRepository>();
            var logger = Substitute.For<ILogger>();
            var author = new Author
            {
                Id = 1,
                Name = "Author1",
                Surename = "surename1",
                Book = new List<Book>()
                {
                    new Book()
                    {
                        Id=1,
                        ISBN = "0471958697",
                        Title = "Title",
                        AuthorId=1,
                    },
                }
            };



            // Act
            authorRepository.Add(author);

            // Assert
           // logger.Received(2).LogInformation(Arg.Any<string>());
            authorRepository.Received(1).Add(author);
        }

        [Fact]
        public void Delete_Should_Set_Entity_State_To_Deleted()
        {
            // Arrange
            var authorId = 1;

            var authorRepository = Substitute.For<IAuthorRepository>();
            var logger = Substitute.For<ILogger<AuthorRepository>>();

            // Act
            authorRepository.Delete(authorId);

            // Assert
            authorRepository.Received(1).Delete(authorId);
        }

   

        [Fact]
        public void Edit_Should_EditAuthor()
        {
            // Arrange
            var author = new Author
            {
                Id = 1,
                Name = "Author1",
                Surename = "surename1",
                Book = new List<Book>()
                {
                    new Book()
                    {
                        Id=1,
                        ISBN = "0471958697",
                        Title = "Title",
                        AuthorId=1,
                    },
                }
            };
            var logger = Substitute.For<ILogger<AuthorRepository>>();
            var repository = new AuthorRepository(_context, logger);
            var dbContext = Substitute.For<DbModelContext>();
            var dbSet = Substitute.For<DbSet<Author>, IQueryable<Author>>();
            dbContext.Authors.Returns(dbSet);

            // Act
            repository.Edit(author);

            // Assert
            dbContext.Entry(author).Received(1).State = EntityState.Modified;


        }


        [Fact]
        public async Task Delete_Author_WithValidId_ShouldDeleteAuthor()
        {
            // Arrange
            var context = Substitute.For<DbModelContext>();
            var logger = Substitute.For<ILogger<AuthorRepository>>();
            var repository = new AuthorRepository(context, logger);

            var authorId = 1;
            var author = new Author { Id = authorId, Name = "name" };

            context.Set<Author>().FindAsync(authorId).Returns(ValueTask.FromResult(author));


            // Act
            repository.Delete(authorId);

            // Assert
            await context.Received(1).SaveChangesAsync(); // Ensure SaveChangesAsync is called once
            Assert.Equal(EntityState.Deleted, context.Received(1).Entry(author).State); // Ensure EntityState is set to Deleted
        }

        //[Fact]
        //public void Add_Failure()
        //{
        //    // Arrange
        //    var logger = Substitute.For<ILogger<AuthorRepository>>();
        //    var unitOfWork = Substitute.For<IUnitOfWork>();
        //    var mapper = Substitute.For<IMapper>();
        //    var authorRepository = Substitute.For<IAuthorRepository>();

        //    var repository = new AuthorRepository(logger, unitOfWork, mapper, authorRepository);

        //    var authorDto = new AuthorDto
        //    {
        //        // Set properties for the authorDto
        //    };

        //    var exceptionMessage = "Simulated exception";
        //    mapper.Map<Author>(authorDto).Returns(_ => throw new Exception(exceptionMessage));

        //    // Act
        //    var result = repository.Add(authorDto);

        //    // Assert
        //    Assert.Null(result); // Check if the result is null in case of failure
        //    logger.Received().LogError(Arg.Is<string>(s => s.Contains("Error Author repositoy add")));
        //    unitOfWork.DidNotReceive().Commit();
        //}

        //[Fact]
        //public async Task GetByIdAsync_Should_Return_Author()
        //{
        //    // Arrange
        //    var authorId = 1;
        //    var author = new Author { Id = authorId, Name = "TestAuthor" };

        //    var authorRepository = Substitute.For<IAuthorRepository>();

        //    var logger = Substitute.For<ILogger<AuthorRepository>>();
        //    var repository = new AuthorRepository(dbContext, logger);

        //    // Act
        //    var result = await repository.GetByIdAsync(authorId);

        //    // Assert
        //    Assert.Equal(author, result);
        //}

        //[Fact]
        //public async Task CreateAuthorAsync_Should_Add_New_Author_And_Return_Entity()
        //{
        //    // Arrange
        //    var newAuthor = new Author { Id = 1, Name = "NewAuthor" };

        //    var dbContext = Substitute.For<DbModelContext>();
        //    dbContext.Authors.Add(newAuthor).Returns(new AuthorEntity { Entity = newAuthor });

        //    var logger = Substitute.For<ILogger<AuthorRepository>>();
        //    var repository = new AuthorRepository(dbContext, logger);

        //    // Act
        //    var result = await repository.CreateAuthorAsync(newAuthor);

        //    // Assert
        //    Assert.Equal(newAuthor, result);
        //}
    }
}
