using ASMPT.ApplicationService.Contract;
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Domain;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowController : ControllerBase
    {
        private readonly ILogger<BorrowController> _logger;
        private readonly IBorrowService _IBorrowService;
        public BorrowController(IBorrowService iBorrowService, ILogger<BorrowController> logger)
        {
            _IBorrowService = iBorrowService;
            _logger = logger;
        }


        [HttpGet]
        [Route("GetBorrowByStudent/{studentId}")]
        public IActionResult GetBorrowByStudent(int studentId)
        {
            var list=_IBorrowService.GetBorrowByStudentId(studentId);
            return Ok(list);
        }


        [HttpGet]
        [Route("GetBorrowByBook/{bookId}")]
        public IActionResult GetBorrowByBook(int bookId)
        {
            var list = _IBorrowService.GetBorrowByBookId(bookId);
            return Ok(list);
        }


        [HttpPost]
        [Route("CreateBorrow")]
        public IActionResult CreateBorrow(CreateBorrow createBorrow )
        {
            _logger.LogInformation("Start to call Get Method in" + nameof(BorrowController));
            try
            {
                int newBorrowId = _IBorrowService.CreateBorrow(createBorrow);

                // Assuming the ID is an integer. Adjust the type accordingly.

                // You can also return the newly created ID in the response.
                return Ok(new { Id = newBorrowId });
            }
            catch (Exception ex)
            {
                _logger.LogError("This is an error log.", ex);
                // Handle the exception or rethrow if needed.
                // throw ex;
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
