using ASMPT.ApplicationService;
using ASMPT.ApplicationService.exception;
using ASMPT.Data.Contract;
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Data.Repository;
using ASMPT.Domain;
using AutoMapper;
using Microsoft.Extensions.Logging;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMTP.ApplicationService.Tests
{
    public class AuthorServiceTests
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AuthorService> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AuthorServiceTests()
        {
            _authorRepository = Substitute.For<IAuthorRepository>();
            _mapper = Substitute.For<IMapper>();
            _logger = Substitute.For<ILogger<AuthorService>>();
            _unitOfWork = Substitute.For<IUnitOfWork>();
        }


        [Fact]
        public async void Add_ValidAuthorDto_CallsAddMethod()
        {
            // Arrange


            var expectedAuthor = new Author { Id = 42, Name = "Author1", Surename = "surename1" };


            var authorService = new AuthorService(_authorRepository, _mapper, _logger, _unitOfWork);
            var authorDto = new CreateAuthorDto
            {
                Name = "Author1",
                Surename = "surename1",
                Book = new List<CreateBookDto>()

                {
                            new CreateBookDto()
                            {
                                ISBN = "4897324",
                                Title = "Title",
                                                            },

                        }
            };

            var exception = Assert.Throws<NotFoundBookIdException>(() => authorService.Add(authorDto));
            Assert.Equal("Invalid Author Paramter", exception.Message);

            _mapper.Map<Author>(authorDto).Returns(expectedAuthor);
            // Act
            authorService.Add(authorDto);

            // Assert
            //TODO
            // _authorRepository.Received(1).Add(ArgExt.Compare(expectedAuthor, new AuthorEqualityComparer()));

            _authorRepository.Received(1).Add(Arg.Is<Author>(a =>
                    a.Id == expectedAuthor.Id &&
                    a.Name == expectedAuthor.Name &&
                    a.Surename == expectedAuthor.Surename &&
                    a.Book.All(b =>
                    b.Id == 1 &&
                    b.ISBN == "4897324" &&
                    b.Title == "Title" &&
                    b.AuthorId == 1
                )));
            _unitOfWork.Received().Commit();
        }



        [Fact]
        public void Add_InvalidAuthorDto_ReturnsNull()
        {
            // Arrange
            var authorService = new AuthorService(_authorRepository, _mapper, _logger, _unitOfWork);
            var authorDto = new CreateAuthorDto
            {
                Name = "Author1",
                Surename = "surename1",
                Book = new List<CreateBookDto>()
                {
                    new CreateBookDto()
                    {
                        ISBN = "4897324",
                        Title = "Title",
                    },
                }
            };

            _mapper.Map<Author>(authorDto).Returns(x => { throw new Exception("Mapping error"); });

            // Act
            var result = authorService.Add(authorDto);

            // Assert
            Assert.Null(result);
        }


        [Fact]
        public void Delete_ShouldCallRepositoryDelete()
        {
            // Arrange

            var authorService = new AuthorService(_authorRepository, _mapper, _logger, _unitOfWork);
            int authorId = 1;

            // Act
            authorService.Delete(authorId);

            // Assert
            _authorRepository.Received(1).Delete(authorId);
            _unitOfWork.Received(1).Commit();
            _logger.Received(1).LogInformation(Arg.Is<string>(msg => msg.Contains($"Deleted an author repository with Id:{authorId}")));

        }

        //[Fact]
        //public void GetById_ValidId_ReturnsAuthorViewModel()
        //{
        //    // Arrange
        //    int authorId = 1010;
        //    var authorService = new AuthorService(_authorRepository, _mapper, _logger, _unitOfWork);
        //    var authorModel = new Author();
        //    var authorViewModel = new AuthorViewModel();
        //    _authorRepository.GetById(authorId).Returns(Task.FromResult(authorModel));
        //    _mapper.Map<AuthorViewModel>(authorModel).Returns(authorViewModel);

        //    // Act
        //    var result = authorService.GetById(authorId);

        //    // Assert
        //    Assert.NotNull(result);
        //    Assert.Same(authorViewModel, result);

        // }



        //[Fact]
        //public void Add_Successful()
        //{
        //    // Arrange


        //    var repository = new AuthorRepository(_context, _logger);

        //    var authorDto = new AuthorDto()
        //    {
        //        Id = 1,
        //        Name = "Author1",
        //        Surename = "surename1",
        //        Book = new List<BookDto>()
        //   {
        //       new BookDto()
        //       {
        //           Id=1,
        //           AuthorId=1,
        //           ISBN="5487998345@",
        //           Title="booktitel"
        //       }
        //   }
        //    };

        //    var author = new Author
        //    {
        //        // Set properties for the mapped author
        //    };

        //    _mapper.Map<Author>(authorDto).Returns(author);
        //    _authorRepository.Add(Arg.Any<Author>()).Returns(42); // Replace 42 with the expected ID

        //    // Act
        //    var result = repository.Add(author);

        //    // Assert
        //    Assert.Equal(42, result); // Check if the returned ID matches the expected value
        //    _logger.Received().LogInformation(Arg.Is<string>(s => s.Contains("Start Author repositoy add")));
        //    _logger.Received().LogInformation(Arg.Is<string>(s => s.Contains("Created a new author repositoy add with Id:")));
        //    _unitOfWork.Received().Commit();
        //}

    }
}
