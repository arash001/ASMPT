using ASMPT.ApplicationService.Contract;
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
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<StudentService> _logger;
        public StudentService(IMapper mapper, IUnitOfWork unitOfWork, IStudentRepository studentRepository, ILogger<StudentService> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _studentRepository = studentRepository;
            _logger = logger;
        }
        public int? Add(StudentDto studentDto)
        {
            _logger.LogInformation("Start saved to the database Student.");

            try
            {
                var student = _mapper.Map<Student>(studentDto);
                _studentRepository.Add(student);
                _unitOfWork.Commit();
                _logger.LogInformation("Changes saved to the database.");
                return studentDto.Id;
            }
            catch (Exception ex )
            {
                _logger.LogError("Error Student Add service", ex);
                return 0;
            }

        }

        public void Delete(int id)
        {
            _studentRepository.Delete(id);
        }

        public void Edit(StudentDto studentDto)
        {
            var student = _mapper.Map<Student>(studentDto);
            _studentRepository.Add(student);
            _unitOfWork.Commit();
        }

        public StudentViewModel GetById(int id)
        {
            var model= _studentRepository.GetById(id);
            return _mapper.Map<StudentViewModel>(model);
        }

        public List<StudentViewModel> GetAll()
        {
            var model = _studentRepository.GetAll();
            return _mapper.Map<List<StudentViewModel>>(model);
        }
        public List<StudentModel> GetStudentyModel()
        {
            var model = _studentRepository.GetAll();
            return _mapper.Map<List<StudentModel>>(model);
        }
    }
}
