using ASMPT.ApplicationService;
using ASMPT.ApplicationService.exception;
using ASMPT.Data.Contract;
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Data.Repository;
using ASMPT.Domain;
using AutoMapper;
using Castle.Core.Logging;
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
        public void Add_ValidAuthorDto_ReturnsAuthorId()
        {
            // Arrange
            var authorRepository = Substitute.For<IAuthorRepository>();
            var mapper = Substitute.For<IMapper>();
            var logger = Substitute.For<ILogger<AuthorService>>();
            var unitOfWork = Substitute.For<IUnitOfWork>();
            var expectedAuthorId = 1;
            var authorService = new AuthorService(authorRepository, mapper, logger, unitOfWork);

            var createAuthorDto = new CreateAuthorDto
            {
                Name = "Author1",
                Surename = "Surename1",
                Book = new List<CreateBookDto>
        {
            new CreateBookDto
            {
                ISBN = "4897324",
                Title = "Title",
            }
        }
            };

            var expectedAuthor = new Author { Id = expectedAuthorId };
            mapper.Map<Author>(createAuthorDto).Returns(expectedAuthor);

            // Act
            var result = authorService.Add(createAuthorDto);

            // Assert
            Assert.Equal(expectedAuthorId, result);
            //authorRepository.Received(1).Add(Arg.Is<Author>(a =>
            //    a.Id == expectedAuthorId &&
            //    a.Name == createAuthorDto.Name &&
            //    a.Surename == createAuthorDto.Surename &&
            //    a.Book.Count == createAuthorDto.Book.Count &&
            //    a.Book.All(b =>
            //        b.ISBN == "4897324" &&
            //        b.Title == "Title" &&
            //        b.AuthorId == 1 &&
            //        b.Id == 1
            //    )
            //));

            unitOfWork.Received(1).Commit();
       
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
            _authorRepository.GetById(authorId).Returns((Author)null);

            // Act
            authorService.Delete(authorId);

            // Assert
            _authorRepository.Received(1).GetById(Arg.Is<int>(id => id == authorId));
            //_authorRepository.Received(1).GetById(authorId);
            _authorRepository.Received(1).Delete(authorId);
            _unitOfWork.Received(1).Commit();
       //     _logger.Received(1).LogInformation(Arg.Any<string>());
       


        }



        [Fact]
        public void GetById_ValidId_ReturnsAuthorViewModel()
        {
            // Arrange
            int authorId = 1010;
            var authorService = new AuthorService(_authorRepository, _mapper, _logger, _unitOfWork);
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
                ISBN = "4897324",
                Title = "Title",
                AuthorId=1,
            },
        }
            };

            var authorViewModel = new AuthorViewModel
            {
                Name = "Author1",
                Surename = "surename1",
                Book = new List<BookViewModel>()
                {
                    new BookViewModel()
                    {
                        ISBN = "4897324",
                        Title = "Title",
                    },
                }
            };
            _authorRepository.GetById(authorId).Returns(author);
            _mapper.Map<AuthorViewModel>(authorViewModel).Returns(authorViewModel);

            // Act
            var result = authorService.GetById(authorId);

            // Assert
            Assert.NotNull(result);
            Assert.Same(authorViewModel, result);

         }



     

    }
}
