using ASMPT.ApplicationService;
using ASMPT.Data.Contract;
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Data.Repository;
using ASMPT.Domain;
using AutoMapper;
using Microsoft.Extensions.Logging;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMTP.ApplicationService.Tests
{
    public class BorrowSerciceTests
    {

        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IBorrowRepository _borrowRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<BorrowService> _logger;

        public BorrowSerciceTests()
        {
            _authorRepository = Substitute.For<IAuthorRepository>();
            _mapper = Substitute.For<IMapper>();
            _studentRepository = Substitute.For<IStudentRepository>();
            _bookRepository = Substitute.For<IBookRepository>();
            _borrowRepository = Substitute.For<IBorrowRepository>();
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _logger = Substitute.For<ILogger<BorrowService>>();
        }

        //[Fact]
        //public async Task CreateBorrowAsync_WithValidInputs_CreatesBorrowSuccessfully()
        //{
        //    // Arrange

        //    var service = new BorrowService(
        //        _authorRepository,
        //        _mapper,
        //        _studentRepository,
        //        _bookRepository,
        //        _borrowRepository,
        //        _unitOfWork,
        //        _logger
        //    );

        //    var createBorrow = new CreateBorrow
        //    {
        //        BookId = 1,
        //        StudentId = 1
        //    };

        //    var book = new Book { Id = 1 /* Add other properties as needed */ };
        //    var student = new Student { Id = 1 /* Add other properties as needed */ };

        //    _bookRepository.GetById(createBorrow.BookId).Returns(Task.FromResult(book));
        //    _studentRepository.GetByIdAsync(createBorrow.StudentId).Returns(Task.FromResult(student));
        //    _borrowRepository.Create(Arg.Any<Borrow>()).Returns(Task.FromResult(1)); // Adjust as needed

        //    // Act
        //    var result = await service.CreateBorrowAsync(createBorrow);

        //    // Assert
        //    Assert.NotEqual(0, result);
        //    await _borrowRepository.Received(1).Create(Arg.Any<Borrow>());
        //    _unitOfWork.Received(1).Commit();
        //}

        //[Fact]
        //public async Task GetBorrowByStudentIdAsync_WithValidStudentId_ReturnsMappedList()
        //{
        //    // Arrange

        //    var service = new BorrowService(
        //        Substitute.For<IAuthorRepository>(),
        //        _mapper,
        //        Substitute.For<IStudentRepository>(),
        //        Substitute.For<IBookRepository>(),
        //        _borrowRepository,
        //        Substitute.For<IUnitOfWork>(),
        //        _logger
        //    );

        //    var studentId = 1;
        //    var borrowList = new List<Borrow> { /* Initialize with sample data */ };
        //    var borrowViewModelList = new List<BorrowViewModel> { /* Initialize with sample data */ };

        //    _borrowRepository.GetBorrowByStudent(studentId).Returns(Task.FromResult(borrowList));
        //    _mapper.Map<List<BorrowViewModel>>(borrowList).Returns(borrowViewModelList);

        //    // Act
        //    var result = await service.GetBorrowByStudentId(studentId);

        //    // Assert
        //    Assert.Equal(borrowViewModelList, result);
        //    await _borrowRepository.Received(1).GetBorrowByStudent(studentId);
        //    _mapper.Received(1).Map<List<BorrowViewModel>>(borrowList);
        //}

        //[Fact]
        //public  Task GetBorrowByStudentIdAsync_ValidStudentId_ReturnsMappedViewModelList()
        //{
        //    // Arrange
        //    var studentId = 1;
        //    var borrowList = new List<Borrow> { new Borrow() { Id=1, BookId=1002, StartDate=DateTime.Now.AddDays(1),EndDate=DateTime.Now.AddDays(20), StudentId=1} };
        //    _borrowRepository.GetBorrowByStudent(studentId).Returns(borrowList);

        //    var mappedViewModelList = new List<BorrowViewModel> { new BorrowViewModel() { Id = 1, BookId = 1002, StartDate = DateTime.Now.AddDays(1), EndDate = DateTime.Now.AddDays(20), StudentId = 1 } };
        //    _mapper.Map<List<BorrowViewModel>>(borrowList).Returns(mappedViewModelList);

        //    var service = new BorrowService(_authorRepository, _mapper, _studentRepository, _bookRepository, _borrowRepository, _unitOfWork, _logger);

        //    // Act
        //    var result =  service.GetBorrowByStudentId(studentId);

        //    // Assert
        //    Assert.Same(mappedViewModelList, result);
        //}

        //[Fact]
        //public  Task GetBorrowByBookIdAsync_ValidStudentId_ReturnsMappedViewModelList()
        //{
        //    // Arrange
        //    var bookId = 1002;
        //    var borrowList = new List<Borrow> { new Borrow() { Id = 1, BookId = 1002, StartDate = DateTime.Now.AddDays(1), EndDate = DateTime.Now.AddDays(20), StudentId = 1 } };
        //    _borrowRepository.GetBorrowByStudent(bookId).Returns(borrowList);

        //    var mappedViewModelList = new List<BorrowViewModel> { new BorrowViewModel() { Id = 1, BookId = 1002, StartDate = DateTime.Now.AddDays(1), EndDate = DateTime.Now.AddDays(20), StudentId = 1 } };
        //    _mapper.Map<List<BorrowViewModel>>(borrowList).Returns(mappedViewModelList);

        //    var service = new BorrowService(_authorRepository, _mapper, _studentRepository, _bookRepository, _borrowRepository, _unitOfWork, _logger);

        //    // Act
        //    var result =  service.GetBorrowByBookId(bookId);

        //    // Assert
        //    Assert.Same(mappedViewModelList, result);
        //}


    }
}
