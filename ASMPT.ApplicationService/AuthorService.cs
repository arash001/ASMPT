using ASMPT.ApplicationService.Contract;
using ASMPT.Data.Contract;
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace ASMPT.ApplicationService
{
    public class AuthorService : IAuthorService
    {
        private IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AuthorService> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper, ILogger<AuthorService> logger, IUnitOfWork unitOfWork)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public int? Add(AuthorDto authorDto)
        {
            _logger.LogInformation("Start Author repositoy add "+ authorDto);
            try
            {
                var author = _mapper.Map<Author>(authorDto);
                _authorRepository.Add(author);

                _logger.LogInformation("Start Author repositoy add " + authorDto);
                _unitOfWork.Commit();
                return author.Id;
            }
            catch (Exception ex )
            {
                _logger.LogError("Error Author repositoy add " + authorDto, ex.Message);
                return null;
                //throw ex;
            }
        }

        public void Delete(int id)
        {
            _authorRepository.Delete(id);
        }

        public void Edit(AuthorDto authorDto)
        {
            var author = _mapper.Map<Author>(authorDto);
            _authorRepository.Edit(author);
        }

        public AuthorViewModel GetById(int id)
        {
            var model = _authorRepository.GetById(id);
            return _mapper.Map<AuthorViewModel>(model);
        }

        public List<AuthorViewModel> GetAll()
        {
            var list = _authorRepository.GetAll();
            return _mapper.Map<List<AuthorViewModel>>(list);
        }
    }
}
