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
using ASMPT.ApplicationService.exception;

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
        public int? Add(CreateAuthorDto createAuthorDto)
        {

            if (createAuthorDto is null )
            {
                throw new CreateAuthorException("Invalid Author Paramter!!");
            }

            _logger.LogInformation("Start Author repositoy add "+ createAuthorDto);
            
            try
            {
                var author = _mapper.Map<Author>(createAuthorDto);
                _authorRepository.Add(author);
             
                _logger.LogInformation("Start Author repositoy add with New Id" + author.Id);
                _unitOfWork.Commit();
                return author.Id;
            }
            catch (Exception ex )
            {
                _logger.LogError("Error Author repositoy add " + createAuthorDto, ex.Message);
                return null;
                //throw ex;
            }
        }

        public void Delete(int id)
        {
            this._logger.LogInformation("Start getting Author with id: {id}", id);
            var author = _authorRepository.GetById(id);
            if (author is not null)
            {
                throw new CreateAuthorException("Invalid Author Id!!");
            }
            _authorRepository.Delete(id);
            _unitOfWork.Commit();
            this._logger.LogInformation($"Deleted an author repository with Id:{id}");
        }

        public void Edit(AuthorDto authorDto)
        {
            this._logger.LogInformation("Start getting Update Author...");
          
            if (authorDto is not null)
            {
                throw new EditAuthorException();
            }

            var author = _mapper.Map<Author>(authorDto);
            if (author is not null )
                this._logger.LogInformation($"Updated the author in repository is Mapped.");


            _authorRepository.Edit(author);
            _unitOfWork.Commit();
            this._logger.LogInformation($"Updated an author repository.");

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
