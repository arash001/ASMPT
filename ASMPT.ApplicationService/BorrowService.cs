using ASMPT.ApplicationService.Contract;
using ASMPT.ApplicationService.exception;
using ASMPT.Data.Contract;
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Domain;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.ApplicationService
{
    public class BorrowService : IBorrowService
    {
        private IAuthorRepository _authorRepository;
        private IStudentRepository _studentRepository;
        private IBookRepository _bookRepository;
        private IBorrowRepository _borrowRepository;
        private IUnitOfWork _unitOfWork;
        private ILogger<BorrowService> _logger;

        private readonly IMapper _mapper;

        public BorrowService(IAuthorRepository authorRepository, IMapper mapper, IStudentRepository studentRepository, IBookRepository bookRepository, IBorrowRepository borrowRepository, IUnitOfWork unitOfWork, ILogger<BorrowService> logger)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
            _studentRepository = studentRepository;
            _bookRepository = bookRepository;
            _borrowRepository = borrowRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public int CreateBorrow(CreateBorrow createBorrow)
        {
            try
            {
                var book = _bookRepository.GetById(createBorrow.BookId);
                if (book is null)
                {
                    throw new NotFoundBookIdException(createBorrow.BookId.ToString());
                }

                var student = _studentRepository.GetById(createBorrow.StudentId);
                if (student is null)
                {
                    throw new NotFoundStudentIdException(createBorrow.StudentId.ToString());
                }

                var borrow = new Borrow
                {
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(45),
                    StudentId = createBorrow.StudentId,
                    BookId = createBorrow.BookId,
                    Book = book,
                    Student = student,
                };

                // Assuming Create method returns the created entity.
                int createdBorrow = _borrowRepository.Create(borrow);
                _unitOfWork.Commit();

                // Return the ID of the newly created borrow.
                return createdBorrow;
            }
            catch (NotFoundStudentIdException ex)
            {
                // Log the exception or handle it as appropriate.
                _logger.LogError("Entity not found.", ex);
                return 0;
                // Rethrow the exception if needed.
               // throw;
            }

            catch (NotFoundBookIdException ex)
            {
                // Log the exception or handle it as appropriate.
                _logger.LogError("Entity not found.", ex);

                // Rethrow the exception if needed.
                throw;
            }
            catch (Exception ex)
            {
                // Log the general exception.
                _logger.LogError("An error occurred while creating a borrow.", ex);

                // Handle the exception or rethrow it if needed.
                throw new Exception("An error occurred while creating a borrow.", ex);
            }
        }


        public List<BorrowViewModel> GetBorrowByStudentId(int studentId)
        {
            var result= _borrowRepository.GetBorrowByStudent(studentId);
            return _mapper.Map<List<BorrowViewModel>>(result);
        }

        public List<BorrowViewModel> GetBorrowByBookId(int bookId)
        {
            var result= _borrowRepository.GetBorrowByBook(bookId);
            return _mapper.Map<List<BorrowViewModel>>(result);


        }
    }
}
