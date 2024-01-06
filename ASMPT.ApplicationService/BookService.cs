using ASMPT.ApplicationService.Contract;
using ASMPT.Data;
using ASMPT.Data.Contract;
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Data.Repository;
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
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<BookService> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public BookService(IBookRepository bookRepository, IMapper mapper, ILogger<BookService> logger, IUnitOfWork unitOfWork)
        {
            _bookRepository = bookRepository;
            this._mapper = mapper;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }


        public int Add(BookDto bookDto)
        {
            _logger.LogInformation("Start Book repositoy add " + bookDto);
            try
            {
                var book = _mapper.Map<Book>(bookDto);
                _bookRepository.Add(book);
                _unitOfWork.Commit();
                _logger.LogInformation("Book Commit " + bookDto);

                return bookDto.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error Book repositoy add " + bookDto, ex.Message);
                return 0;
            }
        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }

        public void Edit(BookDto bookDto)
        {
            var book = _mapper.Map<Book>(bookDto);
            _bookRepository.Edit(book);
        }

        public BookViewModel GetById(int id)
        {
            var model = _bookRepository.GetById(id);
            return _mapper.Map<BookViewModel>(model);
        }

        public List<BookViewModel> GetAll()
        {
            var model = _bookRepository.GetAll();
            return _mapper.Map<List<BookViewModel>>(model);
        }

        public List<BookModel> GetModels()
        {
            var model = _bookRepository.GetAll();
            return _mapper.Map<List<BookModel>>(model);
        }

       
    }
}
