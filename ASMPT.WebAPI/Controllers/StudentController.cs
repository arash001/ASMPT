using ASMPT.ApplicationService.Contract;
using ASMPT.Data.Contract;
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly ILogger<StudentController> _logger;
        public StudentController(IStudentService studentService, ILogger<StudentController> logger)
        {
            _studentService = studentService;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [Route("create")]
        [HttpPost]
        public async Task<ActionResult> CreateStudent([FromBody] StudentDto studentDto)
        {
            try
            {
                _logger.LogInformation("Start CreateStudent...");
               int? result= _studentService.Add(studentDto);

                _logger.LogInformation("Return  CreateStudent...");
                if (result.HasValue)
                {
                    return Ok(new { NewId = result.Value, title = "Author Created", message = "Author has been created" });
                }
                else
                {
                    return BadRequest(new { title = "Error", message = "Failed to create author" });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { title = "Error", message = "Internal server error" });
               
            }


            //if (result.Succeeded)
            return Ok((new { studentDto, title = "Student Created", message = "Student has been created" }));
            //else
            //    return null;
        }


        [Route("GetStudentById/{id}")]
        [HttpGet]
        public async Task<ActionResult> GetStudentById(int id)
        {
            try
            {
                _logger.LogInformation("Start GetStudentById...");
                var result=_studentService.GetById(id);
            return Ok(  result );

            }
            catch (Exception ex)
            {
                _logger.LogDebug("Error: GetStudentById", ex);
                throw ex;
            }


            //if (result.Succeeded)
            //else
            //    return null;
        }


       
        [HttpGet]
        [Route("getall")]
        public async Task<ActionResult>GetAll()
        {
            try
            {
                _logger.LogInformation("Start GetStudents ...");
                var result = _studentService.GetAll();
                return Ok(result);

            }
            catch (Exception ex)
            {
                _logger.LogDebug("Error: GetStudens", ex);
                throw ex;
            }


            //if (result.Succeeded)
            //else
            //    return null;
        }


        [HttpGet]
        [Route("getmodel")]
        public async Task<ActionResult> GetModels()
        {
            try
            {
                _logger.LogInformation("Start GetStudents ...");
                var result = _studentService.GetStudentyModel();
                return Ok( result);

            }
            catch (Exception ex)
            {
                _logger.LogDebug("Error: GetStudens", ex);
                throw ex;
            }
            //if (result.Succeeded)
            //else
            //    return null;
        }
    }
}
